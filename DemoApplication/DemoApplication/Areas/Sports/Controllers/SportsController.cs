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
            return View();
        }

        public ActionResult GetAllSports()
        {
            SportListModel model = sportHelper.GetSportListModel();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SportTeams(string sportName)
        {
            return PartialView("_SportTeams", sportName);
        }

        public ActionResult GetSportTeams(string sportName)
        {
            SportTeamListModel model = sportHelper.GetSportTeamListModel(sportName);
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SportPlayers(string sportName)
        {
            return PartialView("_SportPlayers", sportName);
        }

        public ActionResult GetSportPlayers(string sportName)
        {
            SportPlayerListModel model = sportHelper.GetSportPlayerListModel(sportName);
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}