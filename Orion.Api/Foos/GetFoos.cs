using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Orion.Data;
using Willezone.Azure.WebJobs.Extensions.DependencyInjection;

namespace Orion.Api.Foos
{
    public static class GetFoos
    {
        [FunctionName("GetFoos")]
        public static async Task<IActionResult> Run([HttpTrigger("GET", Route = "foos")] HttpRequest req, ILogger log, [Inject] OrionDbContext ctx)
            => new OkObjectResult(await ctx.Foo.ToListAsync());
    }
}