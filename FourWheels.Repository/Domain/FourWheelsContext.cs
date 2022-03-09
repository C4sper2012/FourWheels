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

        public FourWheelsContext(DbContextOptions options) : base(options)
        {
            
        }

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

            base.OnModelCreating(builder);
        }
    }
}