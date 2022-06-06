using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrafficFine.Models
{
    public enum Offence
    {
        Speeding,
        DrunkDriving,
        Roadworthy,
        LaneDiscipline,
        RoadTrafficSign,
        FitnessofVehicle,
        FitnessofDriver,
        LicensingOfVehicle,
        LicensingOfDriver
    }
    public class Fine
    {

        [Key]
        public int FineNo { get; set; }
        public string MotoristID { get; set; }
        public string TrafficOfficialID { get; set; }
        public string VehicleRegNo { get; set; }
        public float Amount { get; set; }
        public Offence Offence { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }

        public virtual Motorist Motorist { get; set; }
        public virtual TrafficOfficial TrafficOfficial { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}