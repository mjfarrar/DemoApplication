using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplication.Areas.Teams.Models
{
    public class TeamModel
    {
        public string TeamName { get; set; }
        public string TeamSportName { get; set; }
        public int NumberOfPlayers { get; set; }
    }
}