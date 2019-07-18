using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsService
{
    public interface IServicesService
    {
        IList<ServicesDto> AllServices();
        ServicesDto ServicesDetails(int contactId);
        int AddServices(ServicesDto contactDto);
    }
}
