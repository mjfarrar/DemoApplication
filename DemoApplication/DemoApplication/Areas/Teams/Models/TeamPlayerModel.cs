using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplication.Areas.Teams.Models
{
    public class TeamPlayerModel : TeamModel
    {
        public string PlayerName { get; set; }
        public string PlayerPosition { get; set; }
    }
}