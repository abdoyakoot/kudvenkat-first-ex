using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace kudvenkat_first_ex.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            List<string> list = new List<string>()
            {
               "india",
               "UK",
               "USA"
            }; 

            ViewBag.Countries = list;

            return View ();
        }
    }
}