using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLaborationdata.Repository;
using MvcLaborationdata.Entities;
using MvcLaborationWithAjax4.Models;

namespace MvcLaborationWithAjax4.Mapping
{
    public class CommentModelMapping
    {
        public static CommentEntityModel EntityToModel(Comments comments)
        {
            CommentEntityModel cEntity = new CommentEntityModel();
            cEntity.Id = comments.Id;
            cEntity.CommentPhoto = comments.CommentOnPicture;
            cEntity.CommentAlbum = comments.CommentOnAlbum;
            return cEntity;
        }

        public static Comments ModelToEntity(CommentEntityModel comments)
        {
            Comments model = new Comments();
            model.Id = comments.Id;
            model.CommentOnPicture = comments.CommentPhoto;
            model.CommentOnAlbum = comments.CommentAlbum;
            return model;
        }
    }
}