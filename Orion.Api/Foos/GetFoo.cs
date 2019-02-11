using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Orion.Data;
using Willezone.Azure.WebJobs.Extensions.DependencyInjection;

namespace Orion.Api.Foos
{
    public static class GetFoo
    {
        [FunctionName("GetFoo")]
        public static async Task<IActionResult> Run([HttpTrigger("GET", Route = "foos/{id:int}")] HttpRequest req, ILogger log, int id, [Inject] OrionDbContext ctx)
            => new OkObjectResult(await ctx.Foo.FindAsync(id));
    }
}