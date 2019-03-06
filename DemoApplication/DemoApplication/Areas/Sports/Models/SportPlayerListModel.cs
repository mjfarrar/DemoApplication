using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplication.Areas.Sports.Models
{
    public class SportPlayerListModel
    {
        public IEnumerable<SportPlayerModel> PlayerList { get; set; }
    }
}