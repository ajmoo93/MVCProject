using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using MVC_Project1.Models;


namespace MVCProjektData
{
   public class MVCProjektContext : DbContext
    {
        public MVCProjektContext() : base("name=GalleryContext")
        {

        }
         
        public DbSet<PhotoModel> photo { get; set; }
        public DbSet<AlbumModel> album { get; set; }
        public DbSet<AccountModel> account { get; set; }
        public DbSet<AlbumPhotoModel> albumPhoto { get; set; }
        public DbSet<CommentModel> comment { get; set; }
    }
}
