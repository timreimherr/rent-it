using Rent_It.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rent_It.ViewModels
{
    public class CustomerFormVM
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}