using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace NW.LondonStockAPI.Models
{
    public class LondonStockResponse
    {
        //Ticker Symbol -What stock has been exchanged 
        [JsonProperty("TickerSymbol")]
        public string TickerSymbol { get; set; }

        //Price -At what price the stocks are available
        [JsonProperty("Price")]
        public double Price { get; set; }

        //Number of shares     
        [JsonProperty("NoOfShares")]
        public decimal NoOfShares { get; set; }

        //ID of broker managing the trade
        [JsonProperty("BrokerID")]
        public string BrokerID { get; set; }

    }
}