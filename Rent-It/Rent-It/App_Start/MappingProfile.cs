using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Rent_It.Models;
using Rent_It.Dtos;

namespace Rent_It.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Item, ItemDto>();
            Mapper.CreateMap<ItemDto, Item>();
        }
    }
}