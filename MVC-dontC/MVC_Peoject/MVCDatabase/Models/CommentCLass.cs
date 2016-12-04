using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDatabase.Models
{
    public class CommentCLass
    {
        [Key]
        public Guid id { get; set; }
        public string CommentData { get; set; }
        public string CommentAlbum { get; set; }
    }
}