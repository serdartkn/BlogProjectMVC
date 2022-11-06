using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SubscribeMailManager
    {
        EfRepository<SubscribeMail> efRepository = new EfRepository<SubscribeMail>();
        public int AddMail(SubscribeMail subscribeMail)
        {
            Regex r = new Regex(@"^[\w!#$%&'*+/=?`{|}~^-]+(?:\.[\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}$");
            if (r.IsMatch(subscribeMail.Mail))
            {
                return efRepository.Add(subscribeMail);
            }

            return -1;
        }
    }
}