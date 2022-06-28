using Newtonsoft.Json;

namespace NW.LondonStockAPI.Models
{
    public class LondonStockRequest
    {
        //Ticker Symbol -What stock has been exchanged 
        [JsonProperty("TickerSymbol")]
        public string TickerSymbol { get; set; }

    }
}