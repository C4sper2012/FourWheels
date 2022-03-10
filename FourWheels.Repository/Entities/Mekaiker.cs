namespace FourWheels.Repository.Entities
{
    public class Mekaiker
    {
        public int Id { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Stilling { get; set; }

        public string Fuldenavn => $"{Fornavn} {Efternavn}";

    }
}
