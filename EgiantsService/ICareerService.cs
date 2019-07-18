using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsService
{
    public interface ICareerService
    {
        IList<CareerDto> AllCareers();
        CareerDto CareerDetails(int contactId);
        int AddCareers(CareerDto contactDto);
    }
}
