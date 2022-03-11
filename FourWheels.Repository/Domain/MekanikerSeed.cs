using FourWheels.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Repository.Domain
{
    public class MekanikerSeed
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Mekaiker>().HasData(
                new Mekaiker
                {
                    PKMekanikerID = 1, Stilling = "Svend", Fornavn = "Peter", Efternavn = "Petersen"
                },
                new Mekaiker
                {
                    PKMekanikerID = 2, Stilling = "Lærling", Fornavn = "Jacob", Efternavn = "Jacobsen"
                },
                new Mekaiker
                {
                    PKMekanikerID = 3, Stilling = "Svend", Fornavn = "Svend", Efternavn = "Sved"
                }
            );  
        }
    }
}