using EgiantsService;
using EgiantsWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EgiantsWebsite.Controllers
{
    public class CareerController : Controller
    {
        private readonly ICareerService _careerService;
        public CareerController(ICareerService careerService)
        {
            _careerService = careerService;
        }
        public ActionResult AllCareers()
        {
            var contacts = _careerService.AllCareers();
            var careerApplicationViewModel = new CareerApplicationViewModel
            {
                ContactsList = contacts
            };
            return View(careerApplicationViewModel);

        }
        // GET: Career
        public ActionResult Career()
        {
            return View();
        }
    }
}