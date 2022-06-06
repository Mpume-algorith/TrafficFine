using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrafficFine.Models
{

    public class Motorist : Person
    {
        [Key]
        public string IDNumber { get; set; }
        public double Debt { get; set; }

        public virtual ICollection<Fine> Fines { get; set; }
        public virtual ICollection<Vehicle> vehicles { get; set; }
    }
}
