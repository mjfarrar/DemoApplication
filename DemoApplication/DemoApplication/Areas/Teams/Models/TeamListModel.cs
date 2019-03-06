using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplication.Areas.Teams.Models
{
    public class TeamListModel
    {
        public IEnumerable<TeamModel> TeamsList { get; set; }
    }
}