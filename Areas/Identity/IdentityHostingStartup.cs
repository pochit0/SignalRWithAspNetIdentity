using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(SignalRWithAspNetIdentity.Areas.Identity.IdentityHostingStartup))]

namespace SignalRWithAspNetIdentity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}