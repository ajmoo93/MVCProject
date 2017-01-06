using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProjektData.Repositories
{
    public class CommentRepository
    {
        public void AddNewPhotoComment(Guid photoid, CommentClass newphotoComment)
        {
            using (var context = new MvcDataContext())
            {
                var photoentity = context.photo.FirstOrDefault(p => p.PhotoId == photoid);
                photoentity.PComment.Add(newphotoComment);
                context.photo.AddOrUpdate(photoentity);
                context.SaveChanges();
            }
        }
        public void AddNewAlbumComment(Guid albumid, CommentClass newalbumCommet)
        {
            using (var context = new MvcDataContext())
            {
                var albumentity = context.album.FirstOrDefault(a => a.AlbumId == albumid);
                albumentity.Comment.Add(newalbumCommet);
                context.album.AddOrUpdate(albumentity);
                context.SaveChanges();
            }
        }
    }
}
