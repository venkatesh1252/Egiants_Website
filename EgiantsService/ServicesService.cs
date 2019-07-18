using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsService
{
    public class ServicesService : IServicesService
    {
        List<ServicesDto> fullContactList;
        public ServicesService()
        {
            fullContactList = new List<ServicesDto>();
            fullContactList.Add(new ServicesDto() { Id = 1, Email = "targaryen@gmail.com", ContactNumber = "9876543210", Message = "I need Windows Application" });
            fullContactList.Add(new ServicesDto() { Id = 2, Email = "snow@gmail.com", ContactNumber = "8765432109", Message = "I need Windows Application" });
            fullContactList.Add(new ServicesDto() { Id = 3, Email = "stark@gmail.com", ContactNumber = "7654321098", Message = "I need Web Application" });
            fullContactList.Add(new ServicesDto() { Id = 4, Email = "lannister@gmail.com", ContactNumber = "6543210987", Message = "I need Web Application" });
            fullContactList.Add(new ServicesDto() { Id = 5, Email = "baratheon@gmail.com", ContactNumber = "5432109876", Message = "I need Mobile Application" });
            fullContactList.Add(new ServicesDto() { Id = 6, Email = "smith@gmail.com", ContactNumber = "4321098765", Message = "I need Mobile Application" });
        }
        public int AddServices(ServicesDto contactDto)
        {
            throw new NotImplementedException();
        }

        public IList<ServicesDto> AllServices()
        {
            return fullContactList;
        }

        public ServicesDto ServicesDetails(int contactId)
        {
            var singleContact = fullContactList.FirstOrDefault(cont => cont.Id == contactId);
            return singleContact;
        }
    }
}
