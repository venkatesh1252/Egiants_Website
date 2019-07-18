using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsService
{
    public class CareerService : ICareerService
    {
        List<CareerDto> fullContactList;
        public CareerService()
        {
            fullContactList = new List<CareerDto>();
            fullContactList.Add(new CareerDto() { Id = 1, Email = "targaryen@gmail.com", ContactNumber = "9876543210", Message = "I need Windows Application" });
            fullContactList.Add(new CareerDto() { Id = 2, Email = "snow@gmail.com", ContactNumber = "8765432109", Message = "I need Windows Application" });
            fullContactList.Add(new CareerDto() { Id = 3, Email = "stark@gmail.com", ContactNumber = "7654321098", Message = "I need Web Application" });
            fullContactList.Add(new CareerDto() { Id = 4, Email = "lannister@gmail.com", ContactNumber = "6543210987", Message = "I need Web Application" });
            fullContactList.Add(new CareerDto() { Id = 5, Email = "baratheon@gmail.com", ContactNumber = "5432109876", Message = "I need Mobile Application" });
            fullContactList.Add(new CareerDto() { Id = 6, Email = "smith@gmail.com", ContactNumber = "4321098765", Message = "I need Mobile Application" });
        }
        public int AddCareers(CareerDto contactDto)
        {
            throw new NotImplementedException();
        }

        public IList<CareerDto> AllCareers()
        {
            return fullContactList;
        }

        public CareerDto CareerDetails(int contactId)
        {
            var singleContact = fullContactList.FirstOrDefault(cont => cont.Id == contactId);
            return singleContact;
        }
    }
}
