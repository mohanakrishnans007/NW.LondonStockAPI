using AutoMapper;
using NW.LondonStock.Core.DTO;
using NW.LondonStockAPI.Models;

namespace NW.LondonStockAPI.App_Start
{
    /// <inheritdoc />
    /// <summary>
    /// MappingProfile - to access Automapper 
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