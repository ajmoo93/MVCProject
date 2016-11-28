using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ovning1.Models
{
    public class AdressModel
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string AdressName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime date { get; set; }
    }
}