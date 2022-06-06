using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace TrafficFine.Models
{
    public class Vehicle
    {
        [Key]
        public string RegNumber { get; set; }
        public string MotoristID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public virtual ICollection<Fine> Fines { get; set; }
        public virtual Motorist Motorist { get; set; }
    }
}
