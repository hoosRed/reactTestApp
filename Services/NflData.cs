using System;
using System.Collections.Generic;
using System.Linq;
using reactApp.Models;
using Newtonsoft.Json;

using Newtonsoft.Json.Linq;

namespace reactApp.Services
{
    public class NflData
    {
        NflProjectionsContext nflContext = new NflProjectionsContext();
        public List<NflProj> GetProjections(){
            List<NflProj> nflProjs = nflContext.NflProj.ToList();
            return nflProjs;
        }


    }
}
