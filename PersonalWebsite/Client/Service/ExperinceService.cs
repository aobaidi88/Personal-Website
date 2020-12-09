using PersonalWebsite.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PersonalWebsite.Client.Service
{
    public class ExperinceService:IExperinceService
    {
        private readonly HttpClient httpClient;
        public ExperinceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<Experince>> GetExperinces()
        { 
            var exp = await this.httpClient.GetFromJsonAsync<List<Experince>>("api/Experinces");
            return exp;
        }

        public async Task AddExp(Experince experince)
        {
            await this.httpClient.PostAsJsonAsync("api/Experinces", experince);
        }
    }
}
