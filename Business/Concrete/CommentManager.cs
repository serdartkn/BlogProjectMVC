using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager
    {
        EfRepository<Comment> efRepository = new EfRepository<Comment>();

        public List<Comment> GetAllByBlogId(int id) 
        {
            return efRepository.ListAll(b=>b.BlogId==id);
        }
    }
}