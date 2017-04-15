using System;
using Rent_It.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rent_It.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            var allItems = GetItems();
            return View(allItems);
        }

        public ActionResult Details(int id)
        {
            var item = GetItems().SingleOrDefault(x => x.Id == id);
            return View(item);
        }

        public IEnumerable<Item> GetItems()
        {
            return new List<Item>
            {
                new Item { Id = 1, Name = "Hammer" },
                new Item { Id = 2, Name = "Flash Drive" }
            };
        }
    }
}