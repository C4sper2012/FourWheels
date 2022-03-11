namespace FourWheels.Repository.Entities
{
    public class Mekaiker
    {
        public int PKMekanikerID { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Stilling { get; set; }

        public string Fuldenavn => $"{Fornavn} {Efternavn}";

    }
}
