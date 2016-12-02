using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Peoject.Models;

namespace MvcProjektData
{
    public class MvcProjektContext:DbContext
    {
        public MvcProjektContext() : base("name=GalleryContext")
        {

        }

        public DbSet<PhotoModel> photo { get; set; }
        public DbSet<AlbumModel> album { get; set; }
        public DbSet<AccountModel> account { get; set; }
        public DbSet<AlbumPhotoModel> albumPhoto { get; set; }
        public DbSet<CommentModel> comment { get; set; }
    }
}
