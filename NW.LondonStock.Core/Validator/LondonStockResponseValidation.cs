using NW.LondonStock.Core.Constants;
using NW.LondonStock.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.LondonStock.Core.Validator
{
    public class LondonStockResponseValidation
    {
      public static List<Error>  ValidateResponseFields(CoreLondonStockResponse coreLondonStockResponse)
        {
            var error = new List<Error>();

            if (coreLondonStockResponse == null) return error;

            if (string.IsNullOrEmpty(coreLondonStockResponse.BrokerID))
            {
                error.Add(new Error
                {
                    ErrorCode = ValidationErrorConstants.BrokerIDMandatoryErrorCode
                });
            }


            if (coreLondonStockResponse.NoOfShares == null || !coreLondonStockResponse.NoOfShares.HasValue)
            {
                error.Add(new Error
                {
                    ErrorCode = ValidationErrorConstants.NoOfSharesMandatoryErrorCode
                });
            }

            if(coreLondonStockResponse.Price == null || !coreLondonStockResponse.Price.HasValue)
            {
                error.Add(new Error
                {
                    ErrorCode = ValidationErrorConstants.PriceMandatoryErrorCode
                });
            }

            if (string.IsNullOrEmpty(coreLondonStockResponse.TickerSymbol))
            {
                error.Add(new Error
                {
                    ErrorCode = ValidationErrorConstants.TickerSymbolMandatoryErrorCode
                });
            }
            return error;
        }

    }
}
