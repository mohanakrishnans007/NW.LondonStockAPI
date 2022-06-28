using NW.LondonStock.Core.DTO;
using NW.LondonStock.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task<CoreLondonStockResponse> GetStockDetails(CoreLondonStockRequest stockApiRequest)
        {
            var stockSearchResponse = await _dataAccessLayer.GetStockListingsByTickerSymbol(stockApiRequest);

            if(stockSearchResponse.Errors?.Count>0 || stockSearchResponse == null)
            {

            }

            return stockSearchResponse;
        }
    }
}
