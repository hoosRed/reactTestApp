using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace react_test_app.Controllers
{ 
    [Route("api/[controller]")]
    public class FinancialDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "test", "test"
        };

        [HttpGet("[action]")]
        public string StockDataPull()
        {
            using (var wb = new WebClient())
            {
                string ticker = "MSFT";
                string response = wb.DownloadString("https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol=" + ticker + "&apikey=A3XAZ1TLIGSK658B");
                //Console.WriteLine(response);
                Console.WriteLine(response);
                return response;
            }
        }
    }

    public class StockData
    {
        public string Ticker { get; set; }
        public string Open { get; set; }
    }
};
    

