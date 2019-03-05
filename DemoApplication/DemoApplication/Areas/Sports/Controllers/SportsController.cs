using DemoApplication.Areas.Sports.Helpers;
using DemoApplication.Areas.Sports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace DemoApplication.Areas.Sports.Controllers
{
    public class SportsController : Controller
    {
        private SportsHelper sportHelper = new SportsHelper();

        public ActionResult SportsList() 
        {
            SportListModel model = sportHelper.GetSportListModel();
            return View(model);
        }
    }
}