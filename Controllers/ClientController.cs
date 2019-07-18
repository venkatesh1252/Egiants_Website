using EgiantsService;
using EgiantsWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EgiantsWebsite.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        public ActionResult AllClients()
        {
            var contacts = _clientService.AllClients();
            var clientApplicationViewModel = new ClientApplicationViewModel
            {
                ContactsList = contacts
            };
            return View(clientApplicationViewModel);
        }

        // GET: Client
        public ActionResult Client()
        {
            return View();
        }
    }
}