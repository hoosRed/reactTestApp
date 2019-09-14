using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using reactApp.Models;
using reactApp.Services;
using System.IO;
using Microsoft.AspNetCore.Authentication;

namespace reactApp.Controllers
{
    [Route("api/[controller]")]
    public class FinancialDataController : Controller
    {
        //Login
        [HttpGet("[action]")]
        public async Task Login(string returnUrl = "/")
        {
            Console.WriteLine("Login with AuthO");
            await HttpContext.ChallengeAsync("Auth0",
            new AuthenticationProperties() { RedirectUri = returnUrl });
        }
        

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
                //reader.BsaseStream.Position = 0;

            }
            string json = body;
            SqlData dataService = new SqlData();
            dataService.Signup(json);

        }

    }

};
    

