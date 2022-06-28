using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NW.LondonStockAPI.Models
{
    public class LondonStockRequest
    {
        //Ticker Symbol -What stock has been exchanged 
        [JsonProperty("TickerSymbol")]
        public string TickerSymbol { get; set; }

    }
}