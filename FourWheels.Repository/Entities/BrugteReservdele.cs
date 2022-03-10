using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheels.Repository.Entities
{
    public class BrugerReservdele
    {
        public int ID { get; set; }
        public int Reservedel_ID { get; set; }
        public int ArbejdsordreID { get; set; }
        public int Antal { get; set; }

        public Reservdele Reservdele { get; set; }

    }
}
