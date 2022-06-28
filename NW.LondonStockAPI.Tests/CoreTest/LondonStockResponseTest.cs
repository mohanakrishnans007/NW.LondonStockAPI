using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NW.LondonStock.Core.DTO;
using NW.LondonStock.Core.Validator;

namespace NW.LondonStockAPI.Tests.CoreTest
{
    [TestClass]
    public class LondonStockResponseTest
    {
        [TestMethod]
        public void ValidateResponseFields_MandatoryFieldNoOfShares_ReturnErrorCode()
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
            Assert.AreEqual(result[0].ErrorCode.ToString(), "Error1001");


        }



        [TestMethod]
        public void ValidateResponseFields_MandatoryFieldBrokerID_ReturnErrorCode()
        {

            //Assign
            var mockDbResponse = new CoreLondonStockResponse()
            {
                
                Price = 5000,
                NoOfShares=100,
                TickerSymbol = "AAPL"

            };

            //Act
            var result = LondonStockResponseValidation.ValidateResponseFields(mockDbResponse);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result[0].ErrorCode.ToString(), "Error1000");


        }


        [TestMethod]
        public void ValidateResponseFields_MandatoryFieldPrice_ReturnErrorCode()
        {

            //Assign
            var mockDbResponse = new CoreLondonStockResponse()
            {
                BrokerID= "testbroker12",                
                NoOfShares = 100,
                TickerSymbol = "AAPL"

            };

            //Act
            var result = LondonStockResponseValidation.ValidateResponseFields(mockDbResponse);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result[0].ErrorCode.ToString(), "Error1002");


        }

        [TestMethod]
        public void ValidateResponseFields_MandatoryFieldTickerSymbol_ReturnErrorCode()
        {

            //Assign
            var mockDbResponse = new CoreLondonStockResponse()
            {
                BrokerID = "testbroker12",
                NoOfShares = 100,
                Price= 4343

            };

            //Act
            var result = LondonStockResponseValidation.ValidateResponseFields(mockDbResponse);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result[0].ErrorCode.ToString(), "Error1003");


        }

    }
}
