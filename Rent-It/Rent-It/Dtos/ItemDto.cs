using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent_It.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int ItemTypeId { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        public int NumberAvailable { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

    }
}