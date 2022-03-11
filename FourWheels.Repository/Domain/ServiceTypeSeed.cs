using FourWheels.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Repository.Domain
{
    public class ServiceTypeSeed
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Servicetype>().HasData(
                new Servicetype { Id = 1, ServiceType = "Olieskift" },
                new Servicetype { Id = 2, ServiceType = "Almindelig service" },
                new Servicetype { Id = 3, ServiceType = "Bremseeftersyn" },
                new Servicetype { Id = 4, ServiceType = "Synstjek" },
                new Servicetype { Id = 5, ServiceType = "Karosseriskade" },
                new Servicetype { Id = 6, ServiceType = "Hjulskift" }
            );  
        }
    }
}