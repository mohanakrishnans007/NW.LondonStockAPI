
using NW.LondonStock.Core.DTO;
using NW.LondonStock.Core.Interfaces;
using NW.LondonStock.Core.Validator;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NW.LondonStock.Core
{
    public class LondonStockService : ILondonStockService
    {
        private readonly ILondonStockRepository _dataAccessLayer;

        public LondonStockService(ILondonStockRepository dataAccess)
        {
            _dataAccessLayer = dataAccess;
        }

        /// <summary>
        /// GetStockDetails - returns all the stock details returned from DAL layer
        /// </summary>
        /// <param name="stockApiRequest"></param>
        /// <returns></returns>
        public async Task<CoreLondonStockResponse> GetStockDetails(CoreLondonStockRequest stockApiRequest)
        {
            List<Error> errors = null;
            var stockSearchResponse = await _dataAccessLayer.GetStockListingsByTickerSymbol(stockApiRequest);

            if (stockSearchResponse.Errors?.Count > 0 || stockSearchResponse == null)
            {
                errors = LondonStockResponseValidation.ValidateResponseFields(stockSearchResponse);
                stockSearchResponse.Errors = errors;
            }

            return stockSearchResponse;
        }
    }
}