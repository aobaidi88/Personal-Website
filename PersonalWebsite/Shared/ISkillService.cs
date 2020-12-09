using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PersonalWebsite.Shared;

namespace PersonalWebsite.Shared
{
   public interface ISkillService
    {
        Task<List<Skill>> GetSkills();
        public Task AddSkill(Skill skill);
    }
}
