using PersonalWebsite.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PersonalWebsite.Client.Service
{
    public class EducationService:IEducationService
    {
        private readonly HttpClient httpClient;
        public EducationService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<Education>> GetEducations()
        { 
            var edu = await this.httpClient.GetFromJsonAsync<List<Education>>("api/Educations");
            return edu;
        }

        public async Task AddEdu(Education education)
        {
            await this.httpClient.PostAsJsonAsync("api/Educations", education);
        }
    }
}
