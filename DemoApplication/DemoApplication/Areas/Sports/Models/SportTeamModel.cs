using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplication.Areas.Sports.Models
{
    public class SportTeamModel : SportModel
    {
        public string TeamName { get; set; }

        public int NumberOfTeamPlayers { get; set; }
    }
}