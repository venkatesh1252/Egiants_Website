﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsService
{
     public class ContactDto
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
       
        public string Email { get; set; }
        
        public string ContactNumber { get; set; }
       
        public string City { get; set; }
       
        public string Message { get; set; }
    }
}
