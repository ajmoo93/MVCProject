using System;
using System.Collections.Generic;
using System.Linq;
using MvcLaborationdata.Repository;
using System.Web;
using MvcLaborationdata.Entities;
using MvcLaborationWithAjax4.Models;

namespace MvcLaborationWithAjax4.Mapping
{
    public class AlbumModelMapping
    {
        public static AlbumEntityModel EntityToModel(Album albummodel)
        {
            AlbumEntityModel aEntity = new AlbumEntityModel();
            aEntity.AlbumId = albummodel.AlbumID;
            aEntity.AlbumName = albummodel.AlbumName;
            aEntity.Comment = MapCommentEntityModel(albummodel.AlbumComments);
            return aEntity;
        }

        public static Album ModelToEntity(AlbumEntityModel entityModel)
        {
            var model = new Album();
            model.AlbumID = entityModel.AlbumId;
            model.AlbumName = entityModel.AlbumName;
            model.AlbumComments = MapCommentModel(entityModel.Comment);
            return model;
        }

        public static ICollection<CommentEntityModel> MapCommentEntityModel(ICollection<Comments> comments)
        {
            var res = new List<CommentEntityModel>();
            comments.ToList().ForEach(x => res.Add(MapCommentEntityModel(x)));
            return res;
        }

        public static CommentEntityModel MapCommentEntityModel(Comments comments)
        {
            return new CommentEntityModel
            {
                Id = comments.Id,
                CommentPhoto = comments.CommentOnPicture,
                CommentAlbum = comments.CommentOnAlbum
            };
        }

        public ICollection<Comments> MapCommentEntityModel(ICollection<CommentEntityModel> comments)
        {
            var res = new List<Comments>();
            comments.ToList().ForEach(x => res.Add(MapCommentModel(x)));
            return res;

        }

        public static Comments MapCommentModel(CommentEntityModel comments)
        {
            return new Comments
            {
                Id = comments.Id,
                CommentOnPicture = comments.CommentPhoto,
                CommentOnAlbum = comments.CommentAlbum
            };
        }

        public static ICollection<Photo> MapPhotoModel(ICollection<PhotoEntityModel> photo)
        {
            var res = new List<Photo>();
            photo.ToList().ForEach(x => res.Add(MapPhotoModel(x)));
            return res;
        }

        public static Photo MapPhotoModel(PhotoEntityModel photo)
        {
            return new Photo
            {
                PhotoID = photo.PhotoId,
                PhotoName = photo.PhotoName,
                PhotoComment = PhotoModelMapping.MapCommentModel(photo.Comment)
                
            };
        }
        public static ICollection<PhotoEntityModel> MapPhotoEntityModel(ICollection<Photo> comments)
        {
            var res = new List<PhotoEntityModel>();
            comments.ToList().ForEach(x => res.Add(MapPhotoEntityModel(x)));
            return res;
        }

        public static PhotoEntityModel MapPhotoEntityModel(Photo photo)
        {
            return new PhotoEntityModel
            {
                PhotoId = photo.PhotoID,
                PhotoName = photo.PhotoName,
                Comment = PhotoModelMapping.MapCommentEntityModel(photo.PhotoComment)
            };
        }
    }
   
}