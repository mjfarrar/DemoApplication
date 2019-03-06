using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplication.Areas.Sports.Models
{
    public class SportModel
    {
        public string SportName { get; set; }

        public int NumberOfTeams { get; set; }

        public int NumberOfPlayers { get; set; }
    }
}