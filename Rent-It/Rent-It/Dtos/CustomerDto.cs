using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rent_It.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }

    }
}