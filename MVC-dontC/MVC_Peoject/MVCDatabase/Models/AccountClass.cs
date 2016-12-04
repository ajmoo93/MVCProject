using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDatabase.Models
{
    public class AccountClass
    {
        [Key]
        public Guid id { get; set; }
    }
}