using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

using Microsoft.AspNetCore.Mvc;
using reactApp.Models;
using reactApp.Services;


namespace reactApp.Controllers
{ 
    [Route("api/[controller]")]
    public class NflDataController : Controller
    {
        /// <summary>
        /// Projections Data
        /// </summary>
        /// <returns>The data.</returns>
        [HttpGet("[action]")]
        public IEnumerable<NflProj> ProjectionData()
        {
            NflData nflDataService = new NflData();

            return nflDataService.GetProjections();
        }

    }

};
    

