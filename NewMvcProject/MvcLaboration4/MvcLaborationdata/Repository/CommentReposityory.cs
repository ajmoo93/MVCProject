using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcLaborationdata.Entities;

namespace MvcLaborationdata.Repository
{
    public class CommentReposityory
    {
        public void AddNewPhotoComment(Guid photoid, CommentEntityModel newphotoComment)
        {
            using (var context = new MvcDataContext())
            {
                var photoEnt = context.PhotoEntityModels.FirstOrDefault(x => x.PhotoId == photoid);
                photoEnt.Comment.Add(newphotoComment);
                context.PhotoEntityModels.AddOrUpdate(photoEnt);
                context.SaveChanges();
            }
        }
        public void AddNewAlbumComment(Guid albumid, CommentEntityModel newalbumComment)
        {
            using (var context = new MvcDataContext())
            {
                var albumEnt = context.AlbumEntityModels.FirstOrDefault(x => x.AlbumId == albumid);
                albumEnt.Comment.Add(newalbumComment);
                context.AlbumEntityModels.AddOrUpdate(albumEnt);
                context.SaveChanges();
            }
        }
    }
}
