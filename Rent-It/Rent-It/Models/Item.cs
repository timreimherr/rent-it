using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent_It.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ItemType ItemType { get; set; }

        [Required]
        public int ItemTypeId { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number Available")]
        [Range(1,20)]
        public int NumberAvailable { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }
    }
}