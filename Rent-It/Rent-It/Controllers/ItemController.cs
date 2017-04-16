using System;
using Rent_It.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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


    }
}