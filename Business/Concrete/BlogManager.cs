using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager
    {
        EfRepository<Blog> efRepository = new EfRepository<Blog>();

        public List<Blog> GetAll() 
        {
            return efRepository.ListAll();
        }

        public Blog GetBlogById(int id) 
        {
            return efRepository.ListOne(x=>x.BlogId==id);
        }
    }
}
