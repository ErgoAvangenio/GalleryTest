using System.Data.Entity.ModelConfiguration;

namespace GaleriaDeFotos.Models
{
    class GalleryConfigurations:EntityTypeConfiguration<Photo>
    {
        public GalleryConfigurations()
        {
             this.Property(p => p.Id)
                .IsRequired();

            this.Property(p => p.Id)
                .IsConcurrencyToken();
        }

    }
}