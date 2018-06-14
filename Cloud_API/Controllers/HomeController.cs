using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;//add all the rest
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;


namespace Cloud_API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //make
        public ActionResult GetCarMake(string make)
        {
            HttpWebRequest Request = WebRequest.CreateHttp($"http://localhost:51655/api/Cars/AllCarMakesAPI?make={make}");
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            if (Response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader Data = new StreamReader(Response.GetResponseStream());
                // To see raw data coming from API
                //ViewBag.Data = Data.ReadToEnd();
                string d = Data.ReadToEnd();
                d = "{ cars:" + d + "}";
                JObject JsonData = JObject.Parse(d);

                ViewBag.ShowingMake = JsonData["cars"];
                return View();
            }
            else
            {
                return View("Error");
            }
        }

        //model
        public ActionResult GetCarModel(string model)
        {

             HttpWebRequest Request = WebRequest.CreateHttp($"http://localhost:51655/api/Cars/AllCarModelAPI?model={model}");
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            if (Response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader Data = new StreamReader(Response.GetResponseStream());
                // To see raw data coming from API
                //ViewBag.Data = Data.ReadToEnd();
                string d = Data.ReadToEnd();
                d = "{ cars:" + d + "}";
                JObject JsonData = JObject.Parse(d);

                ViewBag.ShowingModel = JsonData["cars"];
                return View();
            }
            else
            {
                return View("Error");
            }
        }

        //year
        public ActionResult GetCarYear(string year)
        {

            HttpWebRequest Request = WebRequest.CreateHttp($"http://localhost:51655/api/Cars/AllCarYearAPI?year={year}");
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            if (Response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader Data = new StreamReader(Response.GetResponseStream());
                // To see raw data coming from API
                //ViewBag.Data = Data.ReadToEnd();
                string d = Data.ReadToEnd();
                d = "{ cars:" + d + "}";
                JObject JsonData = JObject.Parse(d);

                ViewBag.ShowingYear = JsonData["cars"];
                return View();
            }
            else
            {
                return View("Error");
            }
        }

        //color
        public ActionResult GetCarColor(string color)
        {

            HttpWebRequest Request = WebRequest.CreateHttp($"http://localhost:51655/api/Cars/AllCarColorAPI?color={color}");
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            if (Response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader Data = new StreamReader(Response.GetResponseStream());
                // To see raw data coming from API
                //ViewBag.Data = Data.ReadToEnd();
                string d = Data.ReadToEnd();
                d = "{ cars:" + d + "}";
                JObject JsonData = JObject.Parse(d);

                ViewBag.ShowingColor = JsonData["cars"];
                return View();
            }
            else
            {
                return View("Error");
            }
        }
    }
}