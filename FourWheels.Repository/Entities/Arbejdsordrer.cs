using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWheels.Repository.Entities
{
    public class Arbejdsordrer
    {
        public int ID { get; set; }
        public int Bil_ID { get; set; }
        public int Service_ID { get; set; }
        public int Reservedele { get; set; }

        public int Mekaniker { get; set; }
        public DateTime Oprettet { get; set; } = DateTime.UtcNow;
        public DateTime TidBrugt { get; set; }


        public Mekaiker Mekaiker { get; set; }
        public Bil Bil { get; set; }
        public Servicetype Servicetype { get; set; }
        public List<BrugerReservdele> BrugteReservdele { get; set; }

    }
}
