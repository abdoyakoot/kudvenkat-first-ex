using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kudvenkat_first_ex.Models;

namespace kudvenkat_first_ex.Controllers
{
    public class EmpolyeeController : Controller
    {
        // GET: Empolyee
        public ActionResult Details()
        {
            Empolyee empolyee = new Empolyee()
            {
                EmployeeId = 101,
                Name = "Abdelrahman",
                Gender="Male",
                City="Egypt"
            };

            return View(empolyee);
        }
    }
}