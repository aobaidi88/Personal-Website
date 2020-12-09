using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebsite.Shared
{
   public interface IEmailService
    {
        public Task SendEmail(ContactInfo contact);

        public Task AddEmail(ContactInfo contact);
    }
}
