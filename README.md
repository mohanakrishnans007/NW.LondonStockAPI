# NW.LondonStockAPI
LondonStockAPI - API to receive notification of trades from authorised brokers and expose the updated price to them.



About the Project:
This project is built with Clean Architecture principle  in which the business logic and application model at the Center of the application. Instead of having business logic depend on data access or other infrastructure concerns, this dependency is inverted: infrastructure and implementation details depend on Application Core. 

This is achieved by declaring /defining abstractions, or interfaces in the Application Core, which are then implemented by types defined in the infrastructure layer.

Project Structure:
The Web API contains 4 projects -
*NW.LondonStock.API – Which acts as the Presentation / Controller layer for making the Http Get calls to fetch the desired data.
*NW.LondonStock.Core – Core Layer with business logics, Validations and pass data between the layers.
*NW.LondonStock.Infrastructure – Data Access Layer for Database connectivity and accessing other third party services.
*NW.LondonStock.UnitTests – Followed TDD approach  to unit test  all the changes. 

Swash has been Configured.
So we can Also use swagger to check the API :

http://localhost:55761/swagger/ui/index

