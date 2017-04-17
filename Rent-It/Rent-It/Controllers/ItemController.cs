using System;
using Rent_It.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rent_It.ViewModels;

namespace Rent_It.Controllers
{
    public class ItemController : Controller
    {
        private ApplicationDbContext _context;

        public ItemController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Item
        public ActionResult Index()
        {
            var allItems = _context.Items.Include(x => x.ItemType).ToList();
            return View(allItems);
        }

        public ActionResult Details(int id)
        {
            var item = _context.Items.Include(x => x.ItemType).SingleOrDefault(x => x.Id == id);
            return View(item);
        }

        public ActionResult ItemForm()
        {
            var itemTypes = _context.ItemTypes.ToList();
            var viewModel = new ItemFormVM
            {
                ItemTypes = itemTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Item item)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ItemFormVM
                {
                    Item = item,
                    ItemTypes = _context.ItemTypes.ToList()
                };

                return View("ItemForm", viewModel);
            }

            if (item.Id == 0)
            {
                item.DateAdded = DateTime.Now;
                _context.Items.Add(item);
            }
            else
            {
                var itemInDb = _context.Items.Single(x => x.Id == item.Id);

                itemInDb.Name = item.Name;
                itemInDb.Description = item.Description;
                itemInDb.ItemTypeId = item.ItemTypeId;
                itemInDb.NumberAvailable = item.NumberAvailable;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Item");
        }

        public ActionResult Edit(int id)
        {
            var item = _context.Items.SingleOrDefault(x => x.Id == id);

            if (item == null)
            {
                return HttpNotFound();
            }

            var viewModel = new ItemFormVM
            {
                Item = item,
                ItemTypes = _context.ItemTypes.ToList()
            };

            return View("ItemForm", viewModel);
        }

    }
}