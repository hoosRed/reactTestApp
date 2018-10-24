using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

using Microsoft.AspNetCore.Mvc;
using react_test_app.Models;
using react_test_app.Services;
using System.IO;

namespace react_test_app.Controllers
{ 
    [Route("api/[controller]")]
    public class FinancialDataController : Controller
    {
        

        [HttpGet("[action]")]
        public IEnumerable<Contact> StockDataPull()
        {
            SqlData myTestData = new SqlData();
            List<Contact> myList = myTestData.GetUsers();

            // need 
            return myList;
        }
        [HttpPost("[action]")]
        public void Signup()
        {
            string body = "";
            using (var reader = new StreamReader(Request.Body))
            {
                body = reader.ReadToEnd();

                // Do something
            }
            //string json = "{'name':'Julia','email':'tylerRedshaw@gmail.com','id':'9888'}";
            string json = body;
            SqlData dataService = new SqlData();
            dataService.Signup(json);

        }
    }

};
    

