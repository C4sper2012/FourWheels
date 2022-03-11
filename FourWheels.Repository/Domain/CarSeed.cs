using FourWheels.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Repository.Domain
{
    public class CarSeed
    {

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Bil>().HasData(
                new Bil
                {
                    FKEjer = 1, ID = 1, Model = "Polo", Producent = "Volkswagen", Registreringsnummer = "AU79747",
                    Stelnummer = "WVWZZZ3CZ8E166237"
                },
                new Bil
                {
                    FKEjer = 3, ID = 2, Model = "CitiGo", Producent = "Skoda", Registreringsnummer = "BK20515",
                    Stelnummer = "TMBZZZAAZHD604375"
                },
                new Bil
                {
                    FKEjer = 2, ID = 3, Model = "Swift", Producent = "Suzuki", Registreringsnummer = "XZ12345",
                    Stelnummer = "SUZI1234567890ABC"
                },
                new Bil
                {
                    FKEjer = 3, ID = 4, Model = "Atenza", Producent = "Mazda", Registreringsnummer = "BD84922",
                    Stelnummer = "JMZGJ593821177805"
                },
                new Bil
                {
                    FKEjer = 4, ID = 5, Model = "ID4", Producent = "Volkswagen", Registreringsnummer = "CU99104",
                    Stelnummer = "WVWELECTRICID404"
                }
            );
        }
    }
}