using DemoApplication.Areas.Shared;
using DemoApplication.Areas.Shared.Models;
using DemoApplication.Areas.Teams.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DemoApplication.Areas.Teams.Helpers
{
    public class TeamsHelper : BaseHelper
    {
        public TeamListModel GetTeamListModel()
        {
            IEnumerable<TeamInfo> teams = GetAllTeams();
            IEnumerable<PlayerInfo> players = GetAllPlayers();

            TeamListModel model = new TeamListModel();
            model.TeamsList = teams.Select(x => new TeamModel() {
                TeamName = x.TeamName,
                TeamSportName = x.TeamSport.SportName,
                NumberOfPlayers = players.Where(y => y.PlayerTeam.TeamName == x.TeamName).Count()
            });
            return model;
        }

        public TeamPlayerListModel GetTeamPlayerListModel(string teamName)
        {
            IEnumerable<PlayerInfo> players = GetAllPlayers().Where(x => x.PlayerTeam.TeamName == teamName);

            TeamPlayerListModel model = new TeamPlayerListModel();
            model.PlayerList = players.Select(x => new TeamPlayerModel() {
                PlayerName = x.PlayerName,
                PlayerPosition = x.PlayerPosition
            });

            return model;
        }

        public AddNewTeamModel GetAddNewTeamModel()
        {
            IEnumerable<SportInfo> sports = GetAllSports();

            AddNewTeamModel model = new AddNewTeamModel();
            model.Sports = sports.Select(x => new System.Web.Mvc.SelectListItem() {
                Text = x.SportName,
                Value = x.SportName
            });
            return model;
        }

        public bool SaveNewTeam(string teamName, string sportName)
        {
            TeamInfo team = new TeamInfo()
            {
                TeamName = teamName,
                TeamSport = new SportInfo()
                {
                    SportName = sportName
                }
            };

            var client = new RestClient(sportsAPI);
            var request = new RestRequest("AddTeam", Method.POST);
            request.AddJsonBody(team);

            var response = client.Execute(request);

            if (response.IsSuccessful)
                return true;

            return false;
        }
    }
}