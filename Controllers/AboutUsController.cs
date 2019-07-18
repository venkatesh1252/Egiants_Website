using EgiantsService;
using EgiantsWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EgiantsWebsite.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService _aboutUsService;
        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }
        public ActionResult AllAboutUs()
        {
            var contacts = _aboutUsService.AllAboutUs();
            var aboutUsApplicationViewModel = new AboutUsApplicationViewModel
            {
                AboutUsList = contacts
            };
            return View(aboutUsApplicationViewModel);

        }
        // GET: AboutUs
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}