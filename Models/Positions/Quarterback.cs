using System;
using reacttestapp.Models;

namespace reactApp.Models.Positions
{
    public class Quarterback : Player
    {
        public Quarterback(string name, string position, string id, int proj, int salary) 
            : base(name, position, id, proj, salary)
        {
        }
    }
}
