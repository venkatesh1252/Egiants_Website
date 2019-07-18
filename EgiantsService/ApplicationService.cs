using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsService
{
    public class ApplicationService : IApplicationService
    {
        List<ContactDto> fullContactList=new List<ContactDto>();
        public ApplicationService()
        {
            fullContactList = new List<ContactDto>();
            fullContactList.Add(new ContactDto() { Id = 1, FirstName = "Daenerys", LastName = "Targaryen", Email = "targaryen@gmail.com", ContactNumber = "9876543210", City = "West Des Moines", Message = "I need Windows Application" });
            fullContactList.Add(new ContactDto() { Id = 2, FirstName = "John", LastName = "Snow", Email = "snow@gmail.com", ContactNumber = "8765432109", City = "Chicago", Message = "I need Windows Application" });
            fullContactList.Add(new ContactDto() { Id = 3, FirstName = "Robb", LastName = "Stark", Email = "stark@gmail.com", ContactNumber = "7654321098", City = "Washington", Message = "I need Web Application" });
            fullContactList.Add(new ContactDto() { Id = 4, FirstName = "Tyrion", LastName = "Lannister", Email = "lannister@gmail.com", ContactNumber = "6543210987", City = "New York", Message = "I need Web Application" });
            fullContactList.Add(new ContactDto() { Id = 5, FirstName = "Robert", LastName = "Baratheon", Email = "baratheon@gmail.com", ContactNumber = "5432109876", City = "Philadelphia", Message = "I need Mobile Application" });
        }
        public int AddContact(ContactDto contactDto)
        {
            fullContactList.Add(contactDto);
                return contactDto.Id;
        }

        public IList<ContactDto> GetAllContacts()
        {
            return fullContactList;
        }

        public ContactDto GetContactDetails(int contactId)
        {
            var singleContact = fullContactList.FirstOrDefault(cont=>cont.Id == contactId);
            return singleContact;
        }
    }
}
