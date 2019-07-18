using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsService
{
    public class ClientService : IClientService
    {
        List<ClientDto> fullContactList;
        public ClientService()
        {
            fullContactList = new List<ClientDto>();
            fullContactList.Add(new ClientDto() { Id = 1, Email = "targaryen@gmail.com", ContactNumber = "9876543210", Message = "I need Windows Application" });
            fullContactList.Add(new ClientDto() { Id = 2, Email = "snow@gmail.com", ContactNumber = "8765432109", Message = "I need Windows Application" });
            fullContactList.Add(new ClientDto() { Id = 3, Email = "stark@gmail.com", ContactNumber = "7654321098", Message = "I need Web Application" });
            fullContactList.Add(new ClientDto() { Id = 4, Email = "lannister@gmail.com", ContactNumber = "6543210987", Message = "I need Web Application" });
            fullContactList.Add(new ClientDto() { Id = 5, Email = "baratheon@gmail.com", ContactNumber = "5432109876", Message = "I need Mobile Application" });
            fullContactList.Add(new ClientDto() { Id = 6, Email = "smith@gmail.com", ContactNumber = "4321098765", Message = "I need Mobile Application" });
        }
        public int AddClients(ClientDto contactDto)
        {
            throw new NotImplementedException();
        }

        public IList<ClientDto> AllClients()
        {
            return fullContactList;
        }

        public ClientDto ClientDetails(int contactId)
        {
            var singleContact = fullContactList.FirstOrDefault(cont => cont.Id == contactId);
            return singleContact;
        }
    }
}
