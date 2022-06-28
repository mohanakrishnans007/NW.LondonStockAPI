using System.Collections.Generic;

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
