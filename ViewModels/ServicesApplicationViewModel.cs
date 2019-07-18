using EgiantsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EgiantsWebsite.ViewModels
{
    public class ServicesApplicationViewModel
    {
        public ServicesApplicationViewModel()
        {
            ContactsList = new List<ServicesDto>();
        }
        public int Id { get; set; }
        public IList<ServicesDto> ContactsList { get; set; }
    }
}