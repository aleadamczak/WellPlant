using ClassLibrary1.Model;
using Microsoft.EntityFrameworkCore;

namespace SEP4.Data;

public class PlantContext:DbContext
{
    public DbSet<Plant> Plants { get; set; }
    public DbSet<PlantPreset> Presets { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ../EfcDataAccess/Database.db");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlantPreset>().HasKey(preset => preset.PresetId);
        modelBuilder.Entity<Plant>().HasKey(plant => plant.Plantid);
    }
}
