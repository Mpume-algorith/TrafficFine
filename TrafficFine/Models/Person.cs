using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrafficFine.Models
{
    public enum Sex
    {
        male,
        female,
        nonBinary
    }
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public Sex Sex { get; set; }
    }
}