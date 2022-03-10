using System.Collections.Generic;
using FourWheels.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Repository.Domain
{
    public class FourWheelsContext : DbContext
    {
        public DbSet<Arbejdsordrer> Arbejdsordrer { get; set; }
        public DbSet<Bil> Biler { get; set; }
        public DbSet<BrugerReservdele> BrugteReservedele { get; set; }
        public DbSet<Kunde> Kunder { get; set; }
        public DbSet<Mekaiker> Mekaikere { get; set; }
        public DbSet<Reservdele> Reservedele { get; set; }
        public DbSet<Servicetype> Servicetyper { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Constraints

            #region Bil

            builder.Entity<Bil>()
                .Property(p => p.Registreringsnummer)
                .HasMaxLength(10)
                .IsUnicode(true);

            builder.Entity<Bil>()
                .Property(p => p.Stelnummer)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Entity<Bil>()
                .Property(p => p.Producent)
                .HasMaxLength(75)
                .IsUnicode(false);

            builder.Entity<Bil>()
                .Property(p => p.Model)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Entity<Bil>()
                .Property(p => p.Ejer);

            #endregion

            #region Kunde

            builder.Entity<Kunde>()
                .Property(p => p.Fornavn)
                .HasMaxLength(50)
                .IsUnicode();

            builder.Entity<Kunde>()
                .Property(p => p.Efternavn)
                .HasMaxLength(50)
                .IsUnicode();

            builder.Entity<Kunde>()
                .Property(p => p.VejNavn)
                .HasMaxLength(75)
                .IsUnicode();

            builder.Entity<Kunde>()
                .Property(p => p.Postnummer);

            builder.Entity<Kunde>()
                .Property(p => p.Bynavn)
                .HasMaxLength(50)
                .IsUnicode();

            builder.Entity<Kunde>()
                .Property(p => p.Telefon)
                .IsUnicode(false)
                .HasMaxLength(15);

            builder.Entity<Kunde>()
                .Property(p => p.Mobil)
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Entity<Kunde>()
                .Property(p => p.Email)
                .IsUnicode();

            #endregion

            #region Arbejdsordrer

            builder.Entity<Arbejdsordrer>()
                .Property(p => p.Bil_ID);

            builder.Entity<Arbejdsordrer>()
                .Property(p => p.Service_ID);

            builder.Entity<Arbejdsordrer>()
                .Property(p => p.Mekaniker);

            builder.Entity<Arbejdsordrer>()
                .Property(p => p.Reservdele);

            builder.Entity<Arbejdsordrer>()
                .Property(p => p.Oprettet);

            builder.Entity<Arbejdsordrer>()
                .Property(p => p.TidBrugt);

            #endregion

            #region BrugerReservdele

            builder.Entity<BrugerReservdele>()
                .Property(p => p.Reservedel_ID);

            builder.Entity<BrugerReservdele>()
                .Property(p => p.Antal);

            #endregion

            #region Servicetype

            builder.Entity<Servicetype>()
                .Property(p => p.ServiceType)
                .HasMaxLength(50)
                .IsUnicode();

            #endregion

            #region Reservedele

            builder.Entity<Reservdele>()
                .Property(p => p.Reservedel)
                .HasMaxLength(50)
                .IsUnicode();

            #endregion

            #region Mekaniker

            builder.Entity<Mekaiker>()
                .Property(p => p.Fornavn)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Entity<Mekaiker>()
                .Property(p => p.Efternavn)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Entity<Mekaiker>()
                .Property(p => p.Stilling)
                .HasMaxLength(20)
                .IsUnicode(false);

            #endregion

            #endregion

            #region Relations

            builder.Entity<Bil>()
                .HasMany<Arbejdsordrer>()
                .WithOne();

            builder.Entity<Bil>()
                .HasOne<Kunde>()
                .WithMany();

            builder.Entity<BrugerReservdele>()
                .HasMany<Arbejdsordrer>()
                .WithOne();

            builder.Entity<BrugerReservdele>()
                .HasMany<Reservdele>()
                .WithOne();

            builder.Entity<Mekaiker>()
                .HasMany<Arbejdsordrer>()
                .WithOne();

            builder.Entity<Servicetype>()
                .HasOne<Arbejdsordrer>()
                .WithMany();

            #endregion

            #region Seed Data

            builder.Entity<Kunde>().HasData(
                new Kunde
                {
                    Bynavn = "Sønderborg", Efternavn = "Heuck", Email = "nico@lai.dk", Fornavn = "Nicolai", Id = 1,
                    Mobil = "12345678", Postnummer = 6400, Telefon = "", Vej_Nummer = "11b", VejNavn = "Gadevej"
                },
                new Kunde
                {
                    Bynavn = "Guderup", Efternavn = "Nielsen", Email = "tobi@s.dk", Fornavn = "Tobias", Id = 2,
                    Mobil = "23647211", Postnummer = 6430, Telefon = "", Vej_Nummer = "42", VejNavn = "Nordborgvej"
                },
                new Kunde
                {
                    Bynavn = "Tønder", Efternavn = "Andreasen", Email = "jan@tved.me", Fornavn = "Jan", Id = 3,
                    Mobil = "22138860", Postnummer = 6270, Telefon = "52148556", Vej_Nummer = "128", VejNavn = "Tved"
                },
                new Kunde
                {
                    Bynavn = "Gråsten", Efternavn = "Voss", Email = "d@n.dk", Fornavn = "Dan", Id = 4,
                    Mobil = "74740010", Postnummer = 6400, Telefon = "", Vej_Nummer = "99e", VejNavn = "Danfossstraße"
                }
            );

            builder.Entity<Bil>().HasData(
                new Bil
                {
                    Ejer = 1, ID = 1, Model = "Polo", Producent = "Volkswagen", Registreringsnummer = "AU79747",
                    Stelnummer = "WVWZZZ3CZ8E166237"
                },
                new Bil
                {
                    Ejer = 3, ID = 2, Model = "CitiGo", Producent = "Skoda", Registreringsnummer = "BK20515",
                    Stelnummer = "TMBZZZAAZHD604375"
                },
                new Bil
                {
                    Ejer = 2, ID = 3, Model = "Swift", Producent = "Suzuki", Registreringsnummer = "XZ12345",
                    Stelnummer = "SUZI1234567890ABC"
                },
                new Bil
                {
                    Ejer = 3, ID = 4, Model = "Atenza", Producent = "Mazda", Registreringsnummer = "BD84922",
                    Stelnummer = "JMZGJ593821177805"
                },
                new Bil
                {
                    Ejer = 4, ID = 5, Model = "ID4", Producent = "Volkswagen", Registreringsnummer = "CU99104",
                    Stelnummer = "WVWELECTRICID404"
                }
            );

            #endregion

            base.OnModelCreating(builder);
        }
    }
}