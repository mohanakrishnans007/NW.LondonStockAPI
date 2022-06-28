using NW.LondonStock.Core.Constants;
using NW.LondonStock.Core.DTO;
using System.Collections.Generic;

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
                    ErrorMessage = ValidationErrorConstants.BrokerIDMandatoryErrorCode
                });
            }


            if (coreLondonStockResponse.NoOfShares == null || !coreLondonStockResponse.NoOfShares.HasValue)
            {
                error.Add(new Error
                {
                    ErrorMessage = ValidationErrorConstants.NoOfSharesMandatoryErrorCode
                });
            }

            if(coreLondonStockResponse.Price == null || !coreLondonStockResponse.Price.HasValue)
            {
                error.Add(new Error
                {
                    ErrorMessage = ValidationErrorConstants.PriceMandatoryErrorCode
                });
            }

            if (string.IsNullOrEmpty(coreLondonStockResponse.TickerSymbol))
            {
                error.Add(new Error
                {
                    ErrorMessage = ValidationErrorConstants.TickerSymbolMandatoryErrorCode
                });
            }
            return error;
        }

    }
}
