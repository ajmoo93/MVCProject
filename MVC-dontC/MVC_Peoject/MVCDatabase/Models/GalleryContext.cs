using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace MVCDatabase.Models
{
    public class GalleryContext : DbContext
    {
        public GalleryContext() : base("name=GalleryContext")
        {

        }

        public DbSet<PhotoCLass> photo { get; set; }
        public DbSet<AlbumClass> album { get; set; }
        public DbSet<AccountClass> account { get; set; }
        public DbSet<AlbumPhotoCLass> albumPhoto { get; set; }
        public DbSet<CommentCLass> comment { get; set; }
    }
}