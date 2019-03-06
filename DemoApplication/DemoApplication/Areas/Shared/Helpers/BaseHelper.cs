using DemoApplication.Areas.Shared.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DemoApplication.Areas.Shared
{
    public class BaseHelper
    {
        public string sportsAPI = ConfigurationManager.AppSettings["SportsAPIURL"] + "api/sports";

        public IEnumerable<SportInfo> GetAllSports()
        {
            var client = new RestClient(sportsAPI);
            var request = new RestRequest("GetAllSports", Method.GET);

            var response = client.Execute(request);

            IEnumerable<SportInfo> sports = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<SportInfo>>(response.Content);
            return sports;
        }

        public IEnumerable<TeamInfo> GetAllTeams()
        {
            var client = new RestClient(sportsAPI);
            var request = new RestRequest("GetAllTeams", Method.GET);

            var response = client.Execute(request);

            IEnumerable<TeamInfo> teams = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<TeamInfo>>(response.Content);
            return teams;
        }

        public IEnumerable<PlayerInfo> GetAllPlayers()
        {
            var client = new RestClient(sportsAPI);
            var request = new RestRequest("GetAllPlayers", Method.GET);

            var response = client.Execute(request);

            IEnumerable<PlayerInfo> players = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<PlayerInfo>>(response.Content);
            return players;
        }
    }
}