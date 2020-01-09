using System;
using System.Net;
using Common.Core;
using Microsoft.AspNetCore.Mvc;
using DB.DAL.CORE;
using DB.Models.Core.DB;
using Contracts.Customer;
using Newtonsoft.Json;
using BAL;
using Interface.BAL;
using System.Threading.Tasks;

namespace CrxAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private INLogging _logger;
        private IHomeBAL _ihomebal;
        public HomeController(INLogging logger, IHomeBAL ihomebal)
        {
            this._logger = logger; 
            this._ihomebal = ihomebal;
        }


        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    _logger.Information("Nausad test page");
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        [HttpGet]
        [Route("GetData")]
        public string GetData()

        {
            try
            {
                //var b = (a / 0).ToString();
                var b = TestClass.Get(1);
                return b;
            }
            catch (Exception ex)
            {

                _logger.Error(ex);
                return null;
            }



        }

        [HttpPost]
        public  IActionResult  Get(NewCustomerRequest newCustomer)
        {
            //if (newCustomer is null)
            //{
            //    throw new ArgumentNullException(nameof(newCustomer));
            //}
            
            _logger.Information("Request: "+ JsonConvert.SerializeObject(newCustomer));
            
            var result =   _ihomebal.Add(newCustomer);           
            if (result == null)
            {
                _logger.Information("No record found");
                return Ok(new ApiResponse<NewCustomerResponse>
                {
                    ErrorMessage = null,
                    ErrorOccurred = false,
                    ResponseText = "No results found.",
                    Result = result
                });
            }
            var jsonString = JsonConvert.SerializeObject(result);
            _logger.Information("Response: "+jsonString);
            return Ok(new ApiResponse<NewCustomerResponse>
            {
                Result = result,
                StatusCode = HttpStatusCode.OK
            });
        }
    }
}
