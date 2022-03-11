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
            Database.EnsureDeleted();
            Database.EnsureCreated();
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
                .Property(p => p.FKEjer);

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
                .Property(p => p.FKBilID);

            builder.Entity<Arbejdsordrer>()
                .Property(p => p.FKServiceID);

            builder.Entity<Arbejdsordrer>()
                 .Property(p => p.FKMekanikerID);

            // builder.Entity<Arbejdsordrer>()
            //     .Property(p => p.Reservdele);

            builder.Entity<Arbejdsordrer>()
                .Property(p => p.Oprettet);

            builder.Entity<Arbejdsordrer>()
                .Property(p => p.TidBrugt);

            #endregion

            #region BrugerReservdele

            builder.Entity<BrugerReservdele>()
                .Property(p => p.FKReservedelID);

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
                .WithOne(x => x.Bil)
                .HasForeignKey(x => x.FKBilID);

            builder.Entity<Kunde>()
                .HasMany(x => x.Biler)
                .WithOne(x => x.Kunde)
                .HasForeignKey(x => x.FKEjer);

            builder.Entity<BrugerReservdele>()
                .HasOne<Arbejdsordrer>()
                .WithMany()
                .HasForeignKey(x => x.FKArbejdsordreID);

            builder.Entity<BrugerReservdele>()
                .HasOne<Reservdele>()
                .WithMany()
                .HasForeignKey(x => x.FKReservedelID);

            builder.Entity<Mekaiker>()
                .HasMany<Arbejdsordrer>()
                .WithOne()
                .HasForeignKey(x => x.FKMekanikerID).IsRequired(false);

            builder.Entity<Arbejdsordrer>()
                .HasOne<Servicetype>()
                .WithMany()
                .HasForeignKey(x => x.FKServiceID);

            builder.Entity<Arbejdsordrer>().HasKey(x => x.PKArbejdsordreID);
            builder.Entity<Bil>().HasKey(x => x.PKBilID);
            builder.Entity<BrugerReservdele>().HasKey(x => x.PKBrugteReservedeleID);
            builder.Entity<Kunde>().HasKey(x => x.PKKundeID);
            builder.Entity<Mekaiker>().HasKey(x => x.PKMekanikerID);
            builder.Entity<Reservdele>().HasKey(x => x.PKReservedelID);
            builder.Entity<Servicetype>().HasKey(x => x.PKServicetypeID);
            

            #endregion

            #region Seed Data

            CustomerSeed.Seed(builder);
            CarSeed.Seed(builder);
            ServiceTypeSeed.Seed(builder);
            MekanikerSeed.Seed(builder);
            AOSeed.Seed(builder);
            #endregion

            base.OnModelCreating(builder);
        }
    }
}