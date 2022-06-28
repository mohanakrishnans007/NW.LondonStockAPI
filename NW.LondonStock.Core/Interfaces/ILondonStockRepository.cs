using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NW.LondonStock.Core.DTO;

namespace NW.LondonStock.Core.Interfaces
{
    public interface ILondonStockRepository
    {
        Task<CoreLondonStockResponse> GetStockListingsByTickerSymbol(CoreLondonStockRequest stockApiRequest);
    }
}
