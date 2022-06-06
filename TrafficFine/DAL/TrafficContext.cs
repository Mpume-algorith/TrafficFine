using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TrafficFine.Models;

namespace TrafficFine.DAL
{
    public class TrafficContext : DbContext
    {
        public TrafficContext() : base("TrafficContext")
        {
        }

        public DbSet<Motorist> Motorists { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<TrafficOfficial> TrafficOfficials { get; set; }

        //Enforcing Table Title to be Singular
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}