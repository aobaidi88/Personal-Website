using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PersonalWebsite.Shared;
using PersonalWebsite.Client.Service;

namespace PersonalWebsite.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            

            builder.RootComponents.Add<App>("app");

            builder.Services.AddHttpClient("PersonalWebsite.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("PersonalWebsite.ServerAPI"));

            builder.Services.AddApiAuthorization();

            builder.Services.AddScoped<IEmailService, EmailService>();
            builder.Services.AddScoped<IEducationService, EducationService>();
            builder.Services.AddScoped<ISkillService, SkillService>();
            builder.Services.AddScoped<IExperinceService, ExperinceService>();
            await builder.Build().RunAsync();
        }
    }
}
