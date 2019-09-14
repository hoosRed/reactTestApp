using System;
using System.Collections.Generic;

namespace reactApp.Models
{
    public partial class NflProj
    {
        public int Rnk { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public string Pos { get; set; }
        public int? Bye { get; set; }
        public string Game { get; set; }
        public double? Pts { get; set; }
        public double? Sal { get; set; }
        public int? Yds { get; set; }
        public int? Td { get; set; }
        public int? Int { get; set; }
        public double? RuYds { get; set; }
        public double? RuTd { get; set; }
        public double? Rec { get; set; }
        public double? RecYds { get; set; }
        public double? RecTds { get; set; }
        public double? Dk { get; set; }
    }
}
