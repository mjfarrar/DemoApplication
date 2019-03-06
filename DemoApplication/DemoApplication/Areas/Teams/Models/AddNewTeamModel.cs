using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApplication.Areas.Teams.Models
{
    public class AddNewTeamModel
    {
        public IEnumerable<SelectListItem> Sports { get; set; }
    }
}