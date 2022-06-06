using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrafficFine.Models
{
    public class TrafficOfficial : Person
    {
        [Key]
        public string EmployeeID { get; set; }

        public virtual ICollection<Fine> Fines { get; set; }


    }
}
