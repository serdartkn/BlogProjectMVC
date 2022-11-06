using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager
    {
        EfRepository<Category> repoCategory = new EfRepository<Category>();
        public List<Category> GetAll() 
        {
           return repoCategory.ListAll();
        }
    }
}