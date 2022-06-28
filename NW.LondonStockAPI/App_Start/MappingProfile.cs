using AutoMapper;
using NW.LondonStock.Core.DTO;
using NW.LondonStockAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NW.LondonStockAPI.App_Start
{
    /// <inheritdoc />
    /// <summary>
    /// 
    /// </summary>
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {

            CreateMap<CoreLondonStockRequest, LondonStockRequest>();
            CreateMap<CoreLondonStockResponse, LondonStockResponse>();
        }

    }
}