using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using react_test_app.Models;
using react_test_app.Services;

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
            SqlData myTestData = new SqlData();
            List<Contact> myList = myTestData.GetUsers();
            string response = "";
            foreach(Contact user in myList){
                response += user.Name + "_" + user.Email+"_____";
            }
            return response;
        }
    }

    public class StockData
    {
        public string Ticker { get; set; }
        public string Open { get; set; }
    }
};
    

