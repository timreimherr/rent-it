﻿using AutoMapper;
using Rent_It.Dtos;
using Rent_It.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rent_It.Controllers.Api
{
    public class ItemsController : ApiController
    {
        private ApplicationDbContext _context;

        public ItemsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET /api/items
        public IHttpActionResult GetItems()
        {
            return Ok(_context.Items.ToList().Select(Mapper.Map<Item, ItemDto>));
        }

        // GET /api/items/1
        public IHttpActionResult GetItem(int id)
        {
            var item = _context.Items.SingleOrDefault(i => i.Id == id);

            if (item == null)
                return NotFound();

            return Ok(Mapper.Map<Item, ItemDto>(item));
        }

        // POST /api/item
        [HttpPost]
        public IHttpActionResult CreateItem(ItemDto itemDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var item = Mapper.Map<ItemDto, Item>(itemDto);

            _context.Items.Add(item);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + item.Id), item);
        }

  

        // PUT /api/items/1
        [HttpPut]
        public IHttpActionResult UpdateItem(int id, ItemDto itemDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var itemInDb = _context.Items.SingleOrDefault(i => i.Id == id);

            if (itemInDb == null)
                return NotFound();

            Mapper.Map(itemDto, itemInDb);
            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/items/1
        [HttpDelete]
        public IHttpActionResult DeleteItem(int id)
        {
            var itemInDb = _context.Items.SingleOrDefault(i => i.Id == id);

            if (itemInDb == null)
                return NotFound();

            _context.Items.Remove(itemInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}