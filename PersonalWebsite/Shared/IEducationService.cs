using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PersonalWebsite.Shared;

namespace PersonalWebsite.Shared
{
   public interface IEducationService
    {
        Task<List<Education>> GetEducations();
        public Task AddEdu(Education education);
    }
}
