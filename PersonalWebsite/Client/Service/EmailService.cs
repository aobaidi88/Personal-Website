using PersonalWebsite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PersonalWebsite.Client.Service
{
    public class EmailService:IEmailService
    {
        private readonly HttpClient httpClient;
        public EmailService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task AddEmail(ContactInfo contact)
        {
            await this.httpClient.PostAsJsonAsync("api/ContactInfoes", contact);
        }

        public async Task SendEmail(ContactInfo contact)
        {
            await this.httpClient.PostAsJsonAsync("api/email", contact);
        }
    }
}
