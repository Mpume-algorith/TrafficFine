using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TrafficFine.Models;


namespace TrafficFine.DAL
{
    public class TrafficInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TrafficContext>
    {
        protected override void Seed(TrafficContext context)
        {
            

            // Look for any students.
            /*if (context.Motorists.Any())
            {
                return;   // DB has been seeded
            }*/
            //MOTORIST
            var motorists = new Motorist[]
            {
            new Motorist{IDNumber="9605225252086",Name="Mpumelelo",LastName="Alexander", Sex=Sex.male,DateOfBirth=DateTime.Parse("1996-05-22"), Debt=2000},
            new Motorist{IDNumber="9707115252082",Name="Lihle",LastName="Alex", Sex=Sex.female,DateOfBirth=DateTime.Parse("1997-07-11"), Debt=800},
            new Motorist{IDNumber="9803185252086",Name="East",LastName="Billy", Sex=Sex.nonBinary,DateOfBirth=DateTime.Parse("1998-03-18"), Debt=300}

            };
            foreach (Motorist m in motorists)
            {
                context.Motorists.Add(m);
            }
            context.SaveChanges();
            //FINE
            var fines = new Fine[]
            {
            new Fine{FineNo=1050,MotoristID="9605225252086",TrafficOfficialID="100",VehicleRegNo="CA70781", Amount=1500, Location="Cape Town", Offence=Offence.Speeding, Date=DateTime.Parse("2022-03-09 8:30:52 AM")},
            new Fine{FineNo=1051,MotoristID="9605225252086",TrafficOfficialID="101",VehicleRegNo="CA70781", Amount=500, Location="Gqeberha", Offence=Offence.RoadTrafficSign, Date=DateTime.Parse("2020-03-05 12:30:52 PM")},
            new Fine{FineNo=2903,MotoristID="9803185252086",TrafficOfficialID="115",VehicleRegNo="GP10923", Amount=800, Location="Sandton", Offence=Offence.DrunkDriving, Date=DateTime.Parse("2015-09-25 2:15:52 AM")},
            new Fine{FineNo=3294,MotoristID="9707115252082",TrafficOfficialID="100",VehicleRegNo="EC1092", Amount=300, Location="East London", Offence=Offence.DrunkDriving, Date=DateTime.Parse("2015-09-25 2:15:52 AM")}
            };
            foreach (Fine f in fines)
            {
                context.Fines.Add(f);
            }
            context.SaveChanges();

            //TRAFFIC OFFICIAL
            var trafficofficials = new TrafficOfficial[]
            {
                new TrafficOfficial{EmployeeID="100", Name="Mzwakhe", LastName="Mkhize", Sex=Sex.male, DateOfBirth=DateTime.Parse("1980-03-14")},
                new TrafficOfficial{EmployeeID="101", Name="Tshepo", LastName="Motaung", Sex=Sex.male, DateOfBirth=DateTime.Parse("1985-08-12")},
                new TrafficOfficial{EmployeeID="115", Name="Alex", LastName="Boehly", Sex=Sex.female, DateOfBirth=DateTime.Parse("1992-12-04")},
            };
            foreach (TrafficOfficial t in trafficofficials)
            {
                context.TrafficOfficials.Add(t);
            }
            context.SaveChanges();
            //VEHICLE
            var vehicles = new Vehicle[]
            {
                new Vehicle{RegNumber="CA70781", MotoristID="9605225252086", Make="Mercedes Benz", Model="GLE 45 AMG", Year=2021 , Colour="Black", },
                new Vehicle{RegNumber="GP10923", MotoristID="9803185252086", Make="Audi", Model="A3", Year= 2018, Colour="Silver", },
                new Vehicle{RegNumber="EC 1092", MotoristID="9707115252082", Make="Mercedez Benz", Model="C300 AMG", Year= 2020, Colour="White", },

            };
            foreach (Vehicle v in vehicles)
            {
                context.Vehicles.Add(v);
            }
            context.SaveChanges();

        }
    }
}