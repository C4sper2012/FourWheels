using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheels.Repository.Entities
{
    public class Kunde
    {
        public int Id { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string VejNavn { get; set; }
        public string Vej_Nummer { get; set; }
        public int Postnummer { get; set; }
        public string Bynavn { get; set; }
        public string Telefon { get; set; }
        public string Mobil { get; set; }
        public  string Email { get; set; }


    }
}
