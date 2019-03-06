using DemoApplication.Areas.Sports.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using RestSharp;
using DemoApplication.Areas.Shared.Models;
using DemoApplication.Areas.Shared;

namespace DemoApplication.Areas.Sports.Helpers
{
    public class SportsHelper : BaseHelper
    {
        public SportListModel GetSportListModel() 
        {
            IEnumerable<SportInfo> sports = GetAllSports();
            IEnumerable<TeamInfo> teams = GetAllTeams();
            IEnumerable<PlayerInfo> players = GetAllPlayers();

            SportListModel model = new SportListModel();
            model.SportsList = sports.Select(x => new SportModel() {
                SportName = x.SportName,
                NumberOfTeams = teams == null ? 0 : teams.Where(y => y.TeamSport.SportName == x.SportName).Count(),
                NumberOfPlayers = players == null ? 0 : players.Where(y => teams.Any(z => z.TeamName == y.PlayerTeam.TeamName && z.TeamSport.SportName == x.SportName)).Count()
            });

            return model;
        }

        public SportTeamListModel GetSportTeamListModel(string sportName)
        {
            IEnumerable<TeamInfo> teams = GetAllTeams().Where(x => x.TeamSport.SportName == sportName);
            IEnumerable<PlayerInfo> players = GetAllPlayers();

            SportTeamListModel model = new SportTeamListModel();
            model.TeamList = teams.Select(x => new SportTeamModel() {
                TeamName = x.TeamName,
                SportName = sportName,
                NumberOfTeamPlayers = players == null ? 0 : players.Where(y => y.PlayerTeam.TeamName == x.TeamName).Count()
            });

            return model;
        }

        public SportPlayerListModel GetSportPlayerListModel(string sportName)
        {
            IEnumerable<PlayerInfo> players = GetAllPlayers().Where(x => x.PlayerTeam.TeamSport.SportName == sportName);

            SportPlayerListModel model = new SportPlayerListModel();
            model.PlayerList = players.Select(x => new SportPlayerModel()
            {
                PlayerName = x.PlayerName,
                PlayerTeam = x.PlayerTeam.TeamName
            });

            return model;
        }
    }
}