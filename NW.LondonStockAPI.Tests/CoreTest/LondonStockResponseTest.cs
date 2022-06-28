
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NW.LondonStock.Core.DTO;
using NW.LondonStock.Core.Validator;

namespace NW.LondonStockAPI.Tests.CoreTest
{
    /// <summary>
    /// LondonStockResponseTest - Used to tests and validate the response returned
    /// </summary>
    [TestClass]
    public class LondonStockResponseTest
    {
        /// <summary>
        /// ValidateResponseFields_MandatoryFieldNoOfShares_ReturnError - Checks for the mandatory field No Of Shares
        /// and return error message
        /// </summary>
        [TestMethod]
        public void ValidateResponseFields_MandatoryFieldNoOfShares_ReturnError()
        {

            //Assign
            var mockDbResponse = new CoreLondonStockResponse()
            {
                BrokerID = "Broker123",
                Price = 5000,
                TickerSymbol = "AAPL"

            };

            //Act
            var result = LondonStockResponseValidation.ValidateResponseFields(mockDbResponse);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result[0].ErrorMessage.ToString(), "Error1001 : No Of Shares is mandatory");


        }


        /// <summary>
        /// ValidateResponseFields_MandatoryFieldBrokerID_ReturnError - used to check the mandatory field Broker ID and if its
        /// not present return the error message.
        /// </summary>
        [TestMethod]
        public void ValidateResponseFields_MandatoryFieldBrokerID_ReturnError()
        {

            //Assign
            var mockDbResponse = new CoreLondonStockResponse()
            {

                Price = 5000,
                NoOfShares = 100,
                TickerSymbol = "AAPL"

            };

            //Act
            var result = LondonStockResponseValidation.ValidateResponseFields(mockDbResponse);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result[0].ErrorMessage.ToString(), "Error1000 : Broker ID is mandatory");


        }

        /// <summary>
        /// ValidateResponseFields_MandatoryFieldPrice_ReturnError - Checks for the Mandatory field Price if not found
        /// returns the error message
        /// </summary>
        [TestMethod]
        public void ValidateResponseFields_MandatoryFieldPrice_ReturnError()
        {

            //Assign
            var mockDbResponse = new CoreLondonStockResponse()
            {
                BrokerID = "testbroker12",
                NoOfShares = 100,
                TickerSymbol = "AAPL"

            };

            //Act
            var result = LondonStockResponseValidation.ValidateResponseFields(mockDbResponse);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result[0].ErrorMessage.ToString(), "Error1002 : Price is mandatory");


        }

        /// <summary>
        /// ValidateResponseFields_MandatoryFieldTickerSymbol_ReturnError - Checks for the mandatory field ticker symbol and returns
        /// the error message when not found
        /// </summary>
        [TestMethod]
        public void ValidateResponseFields_MandatoryFieldTickerSymbol_ReturnError()
        {

            //Assign
            var mockDbResponse = new CoreLondonStockResponse()
            {
                BrokerID = "testbroker12",
                NoOfShares = 100,
                Price = 4343

            };

            //Act
            var result = LondonStockResponseValidation.ValidateResponseFields(mockDbResponse);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result[0].ErrorMessage.ToString(), "Error1003 : Ticker Symbol is mandatory");


        }

    }
}
