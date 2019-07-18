using EgiantsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EgiantsWebsite.ViewModels
{
    public class AboutUsApplicationViewModel
    {
        public AboutUsApplicationViewModel()
        {
            AboutUsList = new List<AboutUsDto>();
        }
        public int Id { get; set; }
        public IList<AboutUsDto> AboutUsList { get; set; }
    }
}