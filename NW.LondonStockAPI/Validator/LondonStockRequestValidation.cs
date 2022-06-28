using NW.LondonStockAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NW.LondonStockAPI.Validator
{
    public class LondonStockRequestValidation
    {
        /// <summary>
        /// IsTickerSymbolNull - Validates the request to check whether the TicketSymbol is null or empty
        /// </summary>
        /// <param name="londonStockRequest"></param>
        /// <returns></returns>
        public static bool IsTickerSymbolNull(string symbol)
        {
            return string.IsNullOrEmpty(symbol);            

        }
    }
}