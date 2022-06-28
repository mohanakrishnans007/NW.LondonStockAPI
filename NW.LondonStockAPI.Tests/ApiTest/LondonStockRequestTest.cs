using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NW.LondonStockAPI.Validator;

namespace NW.LondonStockAPI.Tests.ApiTest
{
    [TestClass]
    public class LondonStockRequestTest
    {
        /// <summary>
        /// IsTickerSymbolNull_CheckForNull_ShouldReturnTrue checks for is the ticker symbol is
        /// null, then return true
        /// </summary>
        [TestMethod]
        public void IsTickerSymbolNull_CheckForNull_ShouldReturnTrue()
        {
            //Assign
            string tickerSymbol = null;

            //Act
            var result = LondonStockRequestValidation.IsTickerSymbolNull(tickerSymbol);

            //Assert
            Assert.IsTrue(result);

        }

        /// <summary>
        /// IsTickerSymbolNull_CheckForNull_ShouldReturnFalse checks for is the ticker symbol is 
        /// not null then return false
        /// </summary>
        [TestMethod]
        public void IsTickerSymbolNull_CheckForNull_ShouldReturnFalse()
        {
            //Assign
            string tickerSymbol = "test";

            //Act
            var result = LondonStockRequestValidation.IsTickerSymbolNull(tickerSymbol);

            //Assert
            Assert.IsFalse(result);

        }
    }
}
