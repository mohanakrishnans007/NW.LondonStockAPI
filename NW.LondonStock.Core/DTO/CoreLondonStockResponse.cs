using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.LondonStock.Core.DTO
{
   public class CoreLondonStockResponse
    {
        public string TickerSymbol { get; set; }

        public double ?Price { get; set; }

        public decimal ?NoOfShares { get; set; }

        public string BrokerID { get; set; }

        public List<Error> Errors { get; set; }
    }
}
