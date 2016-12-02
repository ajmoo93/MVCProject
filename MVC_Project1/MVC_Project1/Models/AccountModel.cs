using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Project1.Models
{
    public class AccountModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}