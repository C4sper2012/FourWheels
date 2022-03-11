namespace FourWheels.Repository.Entities
{
    public class Arbejdsordrer
    {
        public int PKArbejdsordreID { get; set; }
        public int FKBilID { get; set; }
        public int FKServiceID { get; set; }
        public int? FKBrugteReservedeleID { get; set; }

        public int? FKMekanikerID { get; set; }
        public DateTime Oprettet { get; set; } = DateTime.UtcNow;
        public DateTime TidBrugt { get; set; }


        public Mekaiker? Mekaiker { get; set; }
        public Bil Bil { get; set; }
        public Servicetype? Servicetype { get; set; }
        public List<BrugerReservdele>? BrugteReservdele { get; set; }

    }
}
