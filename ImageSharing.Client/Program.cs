using ImageSharing.Shared.Interfaces;
using ImageSharing.Tests;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace ImageSharing.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped<ISearchService, TestSearchService>();
            await builder.Build().RunAsync();
        }
    }
}
