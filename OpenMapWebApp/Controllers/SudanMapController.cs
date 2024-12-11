////using Microsoft.AspNetCore.Mvc;
using OpenMapWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace OpenMapWebApp.Controllers
{
    // Controller
    public class SudanMapController : Controller
    {

        public SudanMapController()
        {

        }

        public ActionResult Index()
        {

            return View();
        }


        public ActionResult GetPointAreaInfo()
        {

            var points = InMemoryDatabase.GetPoints();
            var areas = InMemoryDatabase.GetAreas();
            
            return Json(new { Points = points, Areas = areas }, JsonRequestBehavior.AllowGet);
        }


    }

}



////------------------------
///

