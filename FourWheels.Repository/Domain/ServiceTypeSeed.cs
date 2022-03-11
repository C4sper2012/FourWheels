using FourWheels.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Repository.Domain
{
    public class ServiceTypeSeed
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Servicetype>().HasData(
                new Servicetype { PKServicetypeID = 1, ServiceType = "Olieskift" },
                new Servicetype { PKServicetypeID = 2, ServiceType = "Almindelig service" },
                new Servicetype { PKServicetypeID = 3, ServiceType = "Bremseeftersyn" },
                new Servicetype { PKServicetypeID = 4, ServiceType = "Synstjek" },
                new Servicetype { PKServicetypeID = 5, ServiceType = "Karosseriskade" },
                new Servicetype { PKServicetypeID = 6, ServiceType = "Hjulskift" }
            );  
        }
    }
}