using NW.LondonStock.Core.DTO;
using NW.LondonStock.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace NW.LondonStock.Infrastructure
{
    public class LondonStockRepository : ILondonStockRepository
    {
        private readonly string _readonlyLondonStockDbConnectionString;

        //Property to create Connection
        private IDbConnection Connection => new OracleConnection();

        public LondonStockRepository()
        {
            _readonlyLondonStockDbConnectionString = ConfigurationManager.ConnectionStrings["ReadOnlyDBConnection"]?.ConnectionString;
        }

        public async Task<CoreLondonStockResponse> GetStockListingsByTickerSymbol(CoreLondonStockRequest stockApiRequest)
        {
            // TODO : Oracle Relational Database Connectiivity and Storage

            //using (var databaseConnection = Connection)
            //{
            //    databaseConnection.Open();
            //    var parameters = new OracleParameter();
            //    parameters.Add()
            //}

            // For testing purposes mocked the response


            var mockDbResponse = new CoreLondonStockResponse()
            {
                BrokerID = "Broker123",
                NoOfShares=100,
                Price= 5000,
                TickerSymbol = "AAPL"
                
            };

            return  mockDbResponse;
        }
    }
}
