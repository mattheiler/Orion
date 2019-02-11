using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Orion.Api;
using Orion.Data;
using Willezone.Azure.WebJobs.Extensions.DependencyInjection;

[assembly: WebJobsStartup(typeof(Startup))]

namespace Orion.Api
{
    internal class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddDependencyInjection(ConfigureServices);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<OrionDbContext>(options => options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Orion;Integrated Security=True"));
        }
    }
}