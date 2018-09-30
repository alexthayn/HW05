using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CountryModel
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public Double Area { get; set; }
        public double PopulationDensity { get; set; }
        public double Coastline { get; set; }
        public double NetMigration { get; set; }
        public double InfantMortality { get; set; }
        public double GDP { get; set; }
        public double Literacy { get; set; }
        public double PhonesPer1000 { get; set; }
        public double BirthRate { get; set; }
        public double DeathRate { get; set; }
    }
}
