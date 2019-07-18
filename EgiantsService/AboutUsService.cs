using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsService
{
    public class AboutUsService : IAboutUsService
    {
        List<AboutUsDto> fullContactList;
        public AboutUsService()
        {
            fullContactList = new List<AboutUsDto>();
            fullContactList.Add(new AboutUsDto() { Id = 1,Email = "targaryen@gmail.com", ContactNumber = "9876543210",Message = "I need Windows Application" });
            fullContactList.Add(new AboutUsDto() { Id = 2,Email = "snow@gmail.com", ContactNumber = "8765432109", Message = "I need Windows Application" });
            fullContactList.Add(new AboutUsDto() { Id = 3,Email = "stark@gmail.com", ContactNumber = "7654321098",Message = "I need Web Application" });
            fullContactList.Add(new AboutUsDto() { Id = 4,Email = "lannister@gmail.com", ContactNumber = "6543210987",Message = "I need Web Application" });
            fullContactList.Add(new AboutUsDto() { Id = 5,Email = "baratheon@gmail.com", ContactNumber = "5432109876",Message = "I need Mobile Application" });
            fullContactList.Add(new AboutUsDto() { Id = 6, Email = "smith@gmail.com", ContactNumber = "4321098765", Message = "I need Mobile Application" });
        }
        public IList<AboutUsDto> AllAboutUs()
        {
            return fullContactList;
        }

        public AboutUsDto AboutUsDetails(int contactId)
        {
            var singleContact = fullContactList.FirstOrDefault(cont => cont.Id == contactId);
            return singleContact;
        }

        public int AddAboutUs(AboutUsDto contactDto)
        {
            throw new NotImplementedException();
        }

    }
}
