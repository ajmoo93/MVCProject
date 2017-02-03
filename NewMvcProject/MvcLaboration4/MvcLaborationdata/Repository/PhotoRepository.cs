using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using MvcLaborationdata.Entities;

namespace MvcLaborationdata.Repository
{
    public class PhotoRepository
    {
        public List<PhotoEntityModel> GetPhotos()
        {
            using (var context = new MvcDataContext())
            {
                var photos = context.PhotoEntityModels.Include("Comment").ToList();
                return photos;
            }
        }

        public void AddPhoto(PhotoEntityModel newphoto)
        {
            using (var context = new MvcDataContext())
            {
                PhotoEntityModel photo = new PhotoEntityModel();
                photo.PhotoId = newphoto.PhotoId;
                photo.PhotoName = newphoto.PhotoName;
                photo.Comment = newphoto.Comment;
                context.PhotoEntityModels.Add(photo);
                context.PhotoEntityModels.AddOrUpdate(photo);
                context.SaveChanges();
            }
        }

        public void DeletePhoto(PhotoEntityModel photo)
        {
            using (var context = new MvcDataContext())
            {
                var deletePhoto =
                    context.PhotoEntityModels.Include("Comment").FirstOrDefault(x => x.PhotoId == photo.PhotoId);
                context.PhotoEntityModels.Remove(deletePhoto);
                context.PhotoEntityModels.AddOrUpdate(deletePhoto);
                context.SaveChanges();
            }
        }

        public PhotoEntityModel GetPhoto(Guid id)
        {
            using (var context = new MvcDataContext())
            {
                return context.PhotoEntityModels.Include("Comment").FirstOrDefault(x => x.PhotoId == id);
            }
        }

        public PhotoEntityModel AddCommentPhoto(Guid id, string photoComment)
        {
            using (var context = new MvcDataContext())
            {
                var photocomment = context.PhotoEntityModels.Include("Comment").FirstOrDefault(x => x.PhotoId == id);
                photocomment.Comment.Add(new CommentEntityModel {Id = Guid.NewGuid(), CommentPhoto = photoComment});
                context.PhotoEntityModels.AddOrUpdate(photocomment);
                context.SaveChanges();
                return photocomment;
            }
        }
    }
}
