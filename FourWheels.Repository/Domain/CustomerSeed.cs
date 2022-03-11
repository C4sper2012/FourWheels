using FourWheels.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Repository.Domain
{
    public class CustomerSeed
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Kunde>().HasData(
                new Kunde
                {
                    Bynavn = "Sønderborg", Efternavn = "Heuck", Email = "nico@lai.dk", Fornavn = "Nicolai", PKKundeID = 1,
                    Mobil = "12345678", Postnummer = 6400, Telefon = "", Vej_Nummer = "11b", VejNavn = "Gadevej"
                },
                new Kunde
                {
                    Bynavn = "Guderup", Efternavn = "Nielsen", Email = "tobi@s.dk", Fornavn = "Tobias", PKKundeID = 2,
                    Mobil = "23647211", Postnummer = 6430, Telefon = "", Vej_Nummer = "42", VejNavn = "Nordborgvej"
                },
                new Kunde
                {
                    Bynavn = "Tønder", Efternavn = "Andreasen", Email = "jan@tved.me", Fornavn = "Jan", PKKundeID = 3,
                    Mobil = "22138860", Postnummer = 6270, Telefon = "52148556", Vej_Nummer = "128", VejNavn = "Tved"
                },
                new Kunde
                {
                    Bynavn = "Gråsten", Efternavn = "Voss", Email = "d@n.dk", Fornavn = "Dan", PKKundeID = 4,
                    Mobil = "74740010", Postnummer = 6400, Telefon = "", Vej_Nummer = "99e", VejNavn = "Danfossstraße"
                }
            );
        }
    }
}