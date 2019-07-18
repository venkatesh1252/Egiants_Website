using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EgiantsWebsite.ViewModels
{
    public class ContactViewModel
    {
       
        public int? Id { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [DisplayName("Contact Number")]
        [Required(ErrorMessage = "Contact Number is required")]
        public string ContactNumber { get; set; }
        [Required(ErrorMessage ="City is required")]
        public string City { get; set; }
        [Required(ErrorMessage ="Message is required")]
        public string Message { get; set; }
    }
}