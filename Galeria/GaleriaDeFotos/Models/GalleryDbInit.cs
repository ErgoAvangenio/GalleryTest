using System.Collections.Generic;
using System.Data.Entity;
using GaleriaDeFotos.Controllers;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;


namespace GaleriaDeFotos.Models
{
    class GalleryDbInit:DropCreateDatabaseAlways<GalleryDbContext>
{
    protected override void Seed(GalleryDbContext context)
    {
        IList<Photo> photo = new List<Photo>();
        photo.Add(new Photo(){Description="descr1",Id=1,ImageUrl="url1",Title= "photo1",UploadDate = DateTime.Now });
        photo.Add(new Photo(){Description="descr2",Id=1,ImageUrl="url12",Title= "photo2",UploadDate = DateTime.Now });
        photo.Add(new Photo(){Description="descr3",Id=1,ImageUrl="url3",Title= "photo3",UploadDate = DateTime.Now });
        context.Photos.AddRange(photo);
        base.Seed(context);

    }
}
}
