using BlazorProject.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProject.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTY3OTg5QDMxMzkyZTM0MmUzMG0wU0JQNlpZbkdqdEdYUFNwRStmdlR0YkU5NGdqTXdCMWhsQWV3YzJMQlE9;NTY3OTkwQDMxMzkyZTM0MmUzMGNRNk1aSEExa2M5RUJRNmxlU0RkLzM1QWZLRkU4ZU8wVDJZalpRbWE2S0E9;NTY3OTkxQDMxMzkyZTM0MmUzMGwzbVQ5R2h5MVJFTGtQY254VDQxMDUzNEMvSW9yK3BkZTVrUkVtbWhKK0E9;NTY3OTkyQDMxMzkyZTM0MmUzMEs1RnNWWEo2emVUeFFsNmVXcHU1UjlqZm9PT05LRTJlY0RQazhaWmVYS3M9;NTY3OTkzQDMxMzkyZTM0MmUzMGFHRmxHeXJ3Y0F5Tk5RVEd2T0pacUlWNDJlakJFT3ZKcU1JYzdwdFljcjQ9;NTY3OTk0QDMxMzkyZTM0MmUzMG5wUVdyU0RRQlk0WWdwWkZocUo1N2tXYytLN1d4NElmQmgzQWNmWDlPSFk9;NTY3OTk1QDMxMzkyZTM0MmUzMGE5K3c2M0xoMDJlQS9SQ21mZHJXWnZBNTlMcW12NEJhaHdJY1VMYVR6YWc9;NTY3OTk2QDMxMzkyZTM0MmUzMGZBQVpMYkZ4eEwvSythWjM3WjNld0hFRzZCdjB2emdCWWNWN0lJNjhEVzg9;NTY3OTk3QDMxMzkyZTM0MmUzMEQrRCsrM1FQenExK3ppZlcrcjBMZUVsVnJxdTNKbEJ6c2psaDFMV3hrbUk9;NTY3OTk4QDMxMzkyZTM0MmUzMElsS0NRaU9EMzg1K001REVZR3hnc25JclZVQUpPVjBSUFpNODJQT3JPYVE9;NTY3OTk5QDMxMzkyZTM0MmUzMFk2ZW5GdVdoUytIS3JuK2ZqaVFTcXFydXpheFJhbXRMS1ZzdnAvemdLTzQ9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddHttpClient<IEmployeeService, EmployeeService>(Client =>
            {
                Client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
            });
                
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddScoped<EmployeeAdapter>();
            await builder.Build().RunAsync();
            await builder.Build().RunAsync();
        }
    }
}
