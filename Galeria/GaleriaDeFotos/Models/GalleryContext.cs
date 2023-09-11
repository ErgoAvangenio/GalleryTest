//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;


namespace GaleriaDeFotos.Models
{
    class GalleryDbContext : DbContext
{
    public DbSet<Photo> Photos{get; set;}
    public GalleryDbContext():base("options")
    {
        Database.SetInitializer<GalleryDbContext>(new GalleryDbInit());
    }
     protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new GalleryConfigurations());

            modelBuilder.Entity<Photo>()
                .ToTable("PhotoInfo");

            modelBuilder.Entity<Photo>()
                .MapToStoredProcedures();
        }
}
}

