using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;

namespace trustlaneweb
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Register Syncfusion license 
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjgzMTYxQDMxMzgyZTMyMmUzMG1oVXFYWmNSMjlYMmU0NUZPTjVSMkdHN3BVQUpuQVZMRjZPRjR2N1ZJbWM9;MjgzMTYyQDMxMzgyZTMyMmUzMFdUWDhnUDR2OS9KNXh4S2pJLzNyeW9SY3ZDWnYxSXJqdjI5MVpDbkgvcG89");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSyncfusionBlazor();

            await builder.Build().RunAsync();
        }
    }
}
