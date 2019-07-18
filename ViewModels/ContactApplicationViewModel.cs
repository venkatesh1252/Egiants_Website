using EgiantsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EgiantsWebsite.ViewModels
{
    public class ContactApplicationViewModel
    {
        public ContactApplicationViewModel()
        {
            ContactsList = new List<ContactDto>();
        }
        public int Id { get; set; }
        public IList<ContactDto> ContactsList { get; set; }
    }
}