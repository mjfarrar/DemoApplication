using DemoApplication.Areas.Teams.Helpers;
using DemoApplication.Areas.Teams.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApplication.Areas.Teams.Controllers
{
    public class TeamsController : Controller
    {
        private TeamsHelper teamHelper = new TeamsHelper();

        public ActionResult TeamsList()
        {
            return View();
        }

        public ActionResult GetAllTeams()
        {
            TeamListModel model = teamHelper.GetTeamListModel();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TeamPlayers(string teamName)
        {
            return PartialView("_TeamPlayers", teamName);
        }

        public ActionResult GetTeamPlayers(string teamName)
        {
            TeamPlayerListModel model = teamHelper.GetTeamPlayerListModel(teamName);
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddNewTeam()
        {
            AddNewTeamModel model = teamHelper.GetAddNewTeamModel();
            return PartialView("_AddNewTeam", model);
        }

        public ActionResult SaveNewTeam(string teamName, string sportName)
        {
            bool result = teamHelper.SaveNewTeam(teamName, sportName);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}