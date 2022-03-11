namespace FourWheels.Repository.Entities
{
    public class BrugerReservdele
    {
        public int PKBrugteReservedeleID { get; set; }
        public int FKReservedelID { get; set; }
        public int FKArbejdsordreID { get; set; }
        public int Antal { get; set; }

        public Reservdele Reservdele { get; set; }

    }
}
