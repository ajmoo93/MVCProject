using System;
using System.Collections.Generic;
using System.Linq;
using MVCProjektData.Repositories;
using MVC_Laboration.Models;
using MVCProjektData;
using System.Web;

namespace MVC_Laboration.Mapping
{
    public class PhotoModelMapping
    {
        public static PhotoClass EntityToModel(PhotoModel photoMod)
        {
            PhotoClass entity = new PhotoClass();
            entity.PhotoId = photoMod.PhotoId;
            entity.PhotoName = photoMod.PhotoName;
            
            
            return entity;
        }
        public static PhotoModel ModelToEntity(PhotoClass photoentity)
        {
            PhotoModel model = new PhotoModel();
            model.PhotoId = photoentity.PhotoId;
            model.PhotoName = photoentity.PhotoName;
            
            return model;
        }
        public static ICollection<CommentClass> MapCommentsEntityModel(ICollection<CommentModel> comments)
        {
            var result = new List<CommentClass>();
            comments.ToList().ForEach(x => result.Add(MapCommentsEntityModel(x)));
            return result;
        }
        public static CommentClass MapCommentsEntityModel(CommentModel comments)
        {
            return new CommentClass
            {
                Id = comments.Id,
                CommentOnPhoto = comments.CommentPhoto
                //CommentAlbum = comments.CommentOnAlbum
            };
        }
        public static ICollection<CommentModel> MapCommentsModel(ICollection<CommentClass> comments)
        {
            var result = new List<CommentModel>();
            comments.ToList().ForEach(x => result.Add(MapCommentsModel(x)));
            return result;
        }
        public static CommentModel MapCommentsModel(CommentClass comments)
        {
            return new CommentModel
            {
                Id = comments.Id,
                CommentPhoto = comments.CommentOnPhoto,
                CommentAlbum = comments.CommentOnAlbum
            };
        }
    }
}