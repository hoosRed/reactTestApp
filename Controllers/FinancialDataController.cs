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
        

        [HttpGet("[action]")]
        public IEnumerable<Contact> StockDataPull()
        {
            SqlData myTestData = new SqlData();
            List<Contact> myList = myTestData.GetUsers();

            // need 
            return myList;
        }
        [HttpPost("[action]")]
        public void AddUser(){
            SqlData myTestData = new SqlData();

        }
    }

    //public class Contact
    //{
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public string Id { get; set; }
    //}
};
    

