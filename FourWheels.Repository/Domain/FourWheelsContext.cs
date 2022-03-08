using FourWheels.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourWheels.Repository.Domain;

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

        #region Bil
        builder.Entity<Kunde>()
               .Property(p => p.Fornavn)
               .HasMaxLength(50)
               .IsUnicode();
        
        builder.Entity<Kunde>()
               .Property(p => p.Efternavn)
               .HasMaxLength(50)
               .IsUnicode();

        builder.Entity<Kunde>()
               .Property(p => p.Vejnavn)
               .HasMaxLength(75)
               .IsUnicode();

        builder.Entity<Kunde>()
               .Property(p => p.Producent)
               .HasMaxLength(75)
               .IsUnicode(false);

        builder.Entity<Kunde>()
               .Property(p => p.Model)
               .HasMaxLength(50)
               .IsUnicode(false);

        builder.Entity<Kunde>()
               .Property(p => p.Ejer);
        #endregion

        base.OnModelCreating(builder);
    }
}