using EgiantsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EgiantsWebsite.ViewModels
{
    public class ClientApplicationViewModel
    {
        public ClientApplicationViewModel()
        {
            ContactsList = new List<ClientDto>();
        }
        public int Id { get; set; }
        public IList<ClientDto> ContactsList { get; set; }
    }
}