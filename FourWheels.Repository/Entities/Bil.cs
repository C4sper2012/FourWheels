using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheels.Repository.Entities
{
    public class Bil
    {
        public int ID { get; set; }
        public string Registreringsnummer { get; set; } // max 10
        public string Stelnummer { get; set; } // max 50
        public string Producent { get; set; } // max 75
        public string Model { get; set; } // max 50
        
        public int FKEjer { get; set; }

        public Kunde Kunde { get; set; }
    }
}
