using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(QuizEMI.Web.Areas.Identity.IdentityHostingStartup))]

namespace QuizEMI.Web.Areas.Identity
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
