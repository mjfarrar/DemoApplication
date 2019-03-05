using DemoApplication.Areas.Sports.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using RestSharp;

namespace DemoApplication.Areas.Sports.Helpers
{
    public class SportsHelper
    {
        string sportsAPI = ConfigurationManager.AppSettings["SportsAPIURL"] + "api/sports";

        //public IEnumerable<SportModel> GetAllSports() 
        //{
        //    IEnumerable<SportModel> sports = null;

        //    using (var client = new HttpClient())
        //    {
        //        HttpResponseMessage response = client.GetAsync(sportsAPI + "GetAllSports").Result;

        //        if (response.IsSuccessStatusCode)
        //        {
        //            string data = response.Content.ReadAsStringAsync().Result;
        //            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        //            sports = jsSerializer.Deserialize<List<SportModel>>(data);
        //        }
        //    }

        //    return sports;
        //}

        public IEnumerable<SportModel> GetAllSports()
        {
            var client = new RestClient(sportsAPI);
            var request = new RestRequest("GetAllSports", Method.GET);

            var response = client.Execute(request);

            IEnumerable<SportModel> sports = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<SportModel>>(response.Content);
            return sports;
        }

        public SportListModel GetSportListModel() 
        {
            SportListModel model = new SportListModel();
            model.SportsList = GetAllSports();
            return model;
        }
    }
}