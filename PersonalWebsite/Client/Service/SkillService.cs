using PersonalWebsite.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PersonalWebsite.Client.Service
{
    public class SkillService:ISkillService
    {
        private readonly HttpClient httpClient;
        public SkillService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<Skill>> GetSkills()
        { 
            var skill = await this.httpClient.GetFromJsonAsync<List<Skill>>("api/Skills");
            return skill;
        }

        public async Task AddSkill(Skill skill)
        {
            await this.httpClient.PostAsJsonAsync("api/Skills", skill);
        }
    }
}
