using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Rsvp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Rsvp(GuestRseponse rseponse)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(rseponse);
                return View("Thanks", rseponse);
            }
            else
            {
                return View();
            }
        }
        [ChildActionOnly]
        public ActionResult Attendees()
        {
            return View(Repository.Rseponses.Where(x => x.WillAttend == true));
        }
    }
}