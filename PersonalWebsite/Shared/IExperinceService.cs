using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PersonalWebsite.Shared;

namespace PersonalWebsite.Shared
{
   public interface IExperinceService
    {
        Task<List<Experince>> GetExperinces();
        public Task AddExp(Experince experince);
    }
}
