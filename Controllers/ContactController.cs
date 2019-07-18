using EgiantsWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EgiantsService;
using AutoMapper;

namespace EgiantsWebsite.Controllers
{
    public class ContactController : Controller
    {
        private readonly IApplicationService _applicationService;
        public ContactController(IApplicationService applicationService)
        {
            _applicationService = applicationService;      
        }
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllContacts()
        {
            var contacts = _applicationService.GetAllContacts();
            var contactApplicationViewModel = new ContactApplicationViewModel
            {
                ContactsList = contacts
            };
            return View(contactApplicationViewModel);
            
        }
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                //Map viewModel to Dto
                var contactDto=Mapper.Map<ContactViewModel,ContactDto>(viewModel);
                //Save the Contact to DataBase
                _applicationService.AddContact(contactDto);
                return RedirectToAction("GetAllContacts");
            }
            return View(viewModel);
        }
       
    }
}