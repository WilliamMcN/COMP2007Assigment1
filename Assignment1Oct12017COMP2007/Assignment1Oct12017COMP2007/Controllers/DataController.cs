using System;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class DataController : Controller
    {
        //Tells the site to wait 10 seconds before next update 
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            //Creating a viewbag time to display the time, "T" means only show the time part not the date and time 
            ViewBag.Time = DateTime.Now.ToString("T");
            return View();
        }
    }
}