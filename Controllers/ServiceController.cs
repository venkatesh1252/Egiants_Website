using EgiantsService;
using EgiantsWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EgiantsWebsite.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServicesService _servicesService;
        public ServiceController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }
        public ActionResult AllServices()
        {
            var contacts = _servicesService.AllServices();
            var servicesApplicationViewModel = new ServicesApplicationViewModel
            {
                ContactsList = contacts
            };
            return View(servicesApplicationViewModel);
        }
        // GET: Service
        public ActionResult Service()
        {
            return View();
        }
    }
}