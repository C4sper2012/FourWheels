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
                    PKArbejdsordreID = 1, FKBilID = 1, FKMekanikerID = 3, Oprettet = DateTime.Now,
                    FKServiceID = 3, 
                },
                new Arbejdsordrer
                {
                    PKArbejdsordreID = 2, FKBilID = 1, FKMekanikerID = 2, Oprettet = DateTime.Now,
                    FKServiceID = 1, 
                },
                new Arbejdsordrer
                {
                    PKArbejdsordreID = 3, FKBilID = 1, FKMekanikerID = 1, Oprettet = DateTime.Now,
                    FKServiceID = 2, 
                },
                new Arbejdsordrer
                {
                    PKArbejdsordreID = 4, FKBilID = 1, FKMekanikerID = 1, Oprettet = DateTime.Now,
                    FKServiceID = 2, 
                },
                new Arbejdsordrer
                {
                    PKArbejdsordreID = 5, FKBilID = 3, FKMekanikerID = 1, Oprettet = DateTime.Now,
                    FKServiceID = 5
                },
                new Arbejdsordrer
                {
                    PKArbejdsordreID = 6, FKBilID = 4, FKMekanikerID = 2, Oprettet = DateTime.Now,
                    FKServiceID = 2, TidBrugt = DateTime.Now.AddHours(-3)
                }
            );  
        }
    }
    
}