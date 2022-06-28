using AutoMapper;
using NW.LondonStock.Core.DTO;
using NW.LondonStock.Core.Interfaces;
using NW.LondonStockAPI.Constants;
using NW.LondonStockAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NW.LondonStockAPI.Controllers
{
    public class LondonStockController : ApiController
    {
        //private fields
        private readonly ILondonStockService _londonStockService;

        ///<inheritdoc/>
        /// <summary>
        /// Controller to initalise repository 
        /// </summary>
        /// <param name="londonStockService"></param>
        public LondonStockController(ILondonStockService londonStockService)
        {
            _londonStockService = londonStockService;
        }

        /// <summary>
        /// GetStockDetails will retrieve the repsonse model based on the request parameters
        /// </summary>
        /// <param name="londonStockRequest"></param>
        /// <returns></returns>
        [HttpGet]
        [Route ("api/v1/TickerSymbol/{symbol}")]        
        public async Task<HttpResponseMessage> GetStockDetails(string symbol)
        {
            // Validate request

            if (symbol == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            if (Validator.LondonStockRequestValidation.IsTickerSymbolNull(symbol))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, LondonStockValidationConstants.RequestNullErrorMessage);

            }

            var stockApiRequest = new CoreLondonStockRequest()
            {
                TickerSymbol = symbol
            };

            var londonStockSearchResopnse = await _londonStockService.GetStockDetails(stockApiRequest);

            if (londonStockSearchResopnse != null)
            {
                var londonStockSearchResult = Mapper.Map<CoreLondonStockResponse, LondonStockResponse>(londonStockSearchResopnse);
                return Request.CreateResponse(HttpStatusCode.OK, londonStockSearchResult);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }
}
