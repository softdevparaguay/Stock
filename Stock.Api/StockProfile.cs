using AutoMapper;
using Stock.Dto;
using Stock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Api
{
    public class StockProfile : Profile
    {
        public StockProfile()
        {
            CreateMap<Cliente, ClienteDto>();
        }
    }
}
