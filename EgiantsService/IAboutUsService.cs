using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgiantsService
{
    public interface IAboutUsService
    {
        IList<AboutUsDto> AllAboutUs();
        AboutUsDto AboutUsDetails(int contactId);
        int AddAboutUs(AboutUsDto contactDto);
    }
}
