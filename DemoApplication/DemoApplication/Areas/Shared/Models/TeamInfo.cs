using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplication.Areas.Shared.Models
{
    public class TeamInfo
    {
        public string TeamName { get; set; }

        public SportInfo TeamSport { get; set; }
    }
}