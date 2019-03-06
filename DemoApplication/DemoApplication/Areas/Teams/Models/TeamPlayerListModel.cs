using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplication.Areas.Teams.Models
{
    public class TeamPlayerListModel
    {
        public IEnumerable<TeamPlayerModel> PlayerList { get; set; }
    }
}