namespace FourWheels.Repository.Entities
{
    public class Reservdele
    {
        public int Id { get; set; }
        public string Reservedel { get; set; }

        public List<BrugerReservdele> BrugteReserveDele { get; set; }
    }
}
