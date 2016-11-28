using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_inlamning.Models
{
    public class PersonModel
    {
        public Guid PId { get; set; }
        public string Name { get; set; }
        public string AdressName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime date { get; set; }
        
    }
}