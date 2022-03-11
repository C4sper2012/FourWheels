namespace FourWheels.Repository.Entities
{
    public class Reservdele
    {
        public int PKReservedelID { get; set; }
        public string Reservedel { get; set; }

        public List<BrugerReservdele>? BrugteReserveDele { get; set; }
    }
}
