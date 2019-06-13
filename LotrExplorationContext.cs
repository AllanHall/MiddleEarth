using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MiddleEarth
{
  public partial class LotrExplorationContext : DbContext
  {
    public LotrExplorationContext()
    {
    }

    public LotrExplorationContext(DbContextOptions<LotrExplorationContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseNpgsql("server=localhost;database=LotrExploration");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");
    }
    public DbSet<SeenCreatures> Creatures { get; set; }
  }
}
