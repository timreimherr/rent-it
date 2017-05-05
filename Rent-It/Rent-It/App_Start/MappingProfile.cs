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
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Item, ItemDto>();

            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<ItemDto, Item>()
                .ForMember(i => i.Id, opt => opt.Ignore());
        }
    }
}