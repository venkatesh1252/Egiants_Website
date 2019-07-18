using EgiantsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EgiantsWebsite.ViewModels
{
    public class CareerApplicationViewModel
    {
        public CareerApplicationViewModel()
        {
            ContactsList = new List<CareerDto>();
        }
        public int Id { get; set; }
        public IList<CareerDto> ContactsList { get; set; }
    }
}