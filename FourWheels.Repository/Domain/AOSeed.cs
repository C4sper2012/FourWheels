using System;
using FourWheels.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Repository.Domain
{
    public class AOSeed
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Arbejdsordrer>().HasData(
                new Arbejdsordrer
                {
                    ID = 1, Bil_ID = 1, Oprettet = DateTime.Now,
                    Service_ID = 3
                },
                new Arbejdsordrer
                {
                    ID = 2, Bil_ID = 3, FKMekanikerID = 1, Oprettet = DateTime.Now,
                    Service_ID = 5
                },
                new Arbejdsordrer
                {
                    ID = 3, Bil_ID = 4, FKMekanikerID = 2, Oprettet = DateTime.Now,
                    Service_ID = 2, TidBrugt = new DateTime(0, 0, 0, 3, 57, 32, 0)
                }
            );  
        }
    }
    
}