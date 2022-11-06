using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutManager
    {
        EfRepository<About> efRepository = new EfRepository<About>();

        public List<About> GetAll() 
        {
            return efRepository.ListAll();
        }
    }
}
