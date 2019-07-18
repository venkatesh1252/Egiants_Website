using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsService
{
    public interface IApplicationService
    {
        IList<ContactDto> GetAllContacts();
        ContactDto GetContactDetails(int contactId);
        int AddContact(ContactDto contactDto);
    }
}
