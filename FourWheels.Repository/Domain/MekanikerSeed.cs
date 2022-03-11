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
                    Id = 1, Stilling = "Svend", Fornavn = "Peter", Efternavn = "Petersen"
                },
                new Mekaiker
                {
                    Id = 2, Stilling = "Lærling", Fornavn = "Jacob", Efternavn = "Jacobsen"
                },
                new Mekaiker
                {
                    Id = 3, Stilling = "Svend", Fornavn = "Svend", Efternavn = "Sved"
                }
            );  
        }
    }
}