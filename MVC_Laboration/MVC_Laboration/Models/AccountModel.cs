using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Laboration.Models
{
    public class AccountModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}