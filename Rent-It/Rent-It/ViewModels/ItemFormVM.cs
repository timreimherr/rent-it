using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rent_It.Models;

namespace Rent_It.ViewModels
{
    public class ItemFormVM
    {
        public Item Item { get; set; }
        public IEnumerable<ItemType> ItemTypes { get; set; }
    }
}