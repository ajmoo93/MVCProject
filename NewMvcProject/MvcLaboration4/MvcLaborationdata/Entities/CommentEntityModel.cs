﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcLaborationdata.Entities
{
   public class CommentEntityModel
    {
        [Key]
        public Guid Id { get; set; }
        public string CommentPhoto { get; set; }
        public string CommentAlbum { get; set; }

    }
}
