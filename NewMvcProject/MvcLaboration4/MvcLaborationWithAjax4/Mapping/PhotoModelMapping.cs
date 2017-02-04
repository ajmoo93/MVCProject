using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLaborationdata.Entities;
using MvcLaborationdata.Repository;
using MvcLaborationWithAjax4.Models;


namespace MvcLaborationWithAjax4.Mapping
{
    public class PhotoModelMapping
    {
        public static PhotoEntityModel EntityToModel(Photo photoModel)
        {
            PhotoEntityModel pEntity = new PhotoEntityModel();
            pEntity.PhotoId = photoModel.PhotoID;
            pEntity.PhotoName = photoModel.PhotoName;
            pEntity.Comment = MapCommentEntityModel(photoModel.PhotoComment);
            return pEntity;
        }

        public static Photo ModelToEntity(PhotoEntityModel photoentity)
        {
            Photo model = new Photo();
            model.PhotoID = photoentity.PhotoId;
            model.PhotoName = photoentity.PhotoName;
            model.PhotoComment = MapCommentModel(photoentity.Comment);
            return model;
        }

        public static ICollection<CommentEntityModel> MapCommentEntityModel(ICollection<Comments> comments)
        {
            var CRes = new List<CommentEntityModel>();
            comments.ToList().ForEach(x => CRes.Add(MapCommentEntityModel(x)));
            return CRes;
        }

        public static CommentEntityModel MapCommentEntityModel(Comments comments)
        {
            return new CommentEntityModel
            {
                Id = comments.Id,
                CommentPhoto = comments.CommentOnPicture
            };
        }

        public static ICollection<Comments> MapCommentModel(ICollection<CommentEntityModel> comments)
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
    }
}