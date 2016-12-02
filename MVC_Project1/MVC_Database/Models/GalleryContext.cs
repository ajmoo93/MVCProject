using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Database.Models
{
    public class GalleryContext : DbContext
    {
        public DbSet<PhotoClass> photos { get; set; }
        public DbSet<AlbumClass> albums { get; set; }
        public DbSet<AlbumPhotoClass> albumPhotos { get; set; }
        public DbSet<CommentClass> comments { get; set; }  
    }
}