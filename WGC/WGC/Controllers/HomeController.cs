using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WGC.Models;

namespace WGC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "WGC";
            FeedbackMessage feedbackMessage = new FeedbackMessage();
            return View(feedbackMessage);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Message(FeedbackMessage feedbackMessage)
        {

            if (ModelState.IsValid)
            {

                //its valid, update your database or do soemthing useful here
                return RedirectToAction("Success");
            }
            //its not valid reload the page and let data annotations show the error
            return View(feedbackMessage);
        }
    }
}