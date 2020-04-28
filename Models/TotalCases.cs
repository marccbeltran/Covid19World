using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace covid19World.Models
{
    public class TotalCases
    {
        public long Updated { get; set; }
        public string Country { get; set; }
        public int Cases { get; set; }
        public int TodayCases { get; set; }
        public int Deaths { get; set; }
        public int TodayDeaths { get; set; }
        public int Recovered { get; set; }
        public int Active { get; set; }
        public int Critical { get; set; }
        public int CasesPerOneMillion { get; set; }
        public int DeathsPerOneMillion { get; set; }
        public int Tests { get; set; }
        public int TestsPerOneMillion { get; set; }

    }
}
