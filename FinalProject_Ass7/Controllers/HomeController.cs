using FinalProject_Ass7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject_Ass7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {

            Trip t = new Trip(Request.Form["truckNumber"],
             Request.Form["driverNumber"],
             Request.Form["coNumber"],
             Request.Form["tripNumber"], 
             DateTime.Parse(Request.Form["dateD"]),
             DateTime.Parse(Request.Form["dateR"]),
             Request.Form["sc"],
             decimal.Parse(Request.Form["miles"]),
             Request.Form["fuelNumber"],
             decimal.Parse(Request.Form["gallon"]),
             decimal.Parse(Request.Form["taxes"]), 
             Request.Form["stationName"], 
             Request.Form["stationLocation"]);

            DB.AddTrip(t);

            return View();
        }
    }
}