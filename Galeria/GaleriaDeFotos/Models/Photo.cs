using System;

namespace GaleriaDeFotos.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
