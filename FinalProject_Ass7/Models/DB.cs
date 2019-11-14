using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_Ass7.Models
{
    public class DB
    {
        private static TripJournalEntities myDb = new TripJournalEntities();
        public static IEnumerable<Trip> GetProducts()
        {
            return myDb.Trips.ToList();
        }

        public static Trip getProduct(int id)
        {
            return myDb.Trips.Find(id);
        }
        public static void AddTrip(Trip t)
        {
            myDb.Trips.Add(t);
            myDb.SaveChanges();

        }

    }
}