using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsService
{
    public interface IClientService
    {
        IList<ClientDto> AllClients();
        ClientDto ClientDetails(int contactId);
        int AddClients(ClientDto contactDto);
    }
}
