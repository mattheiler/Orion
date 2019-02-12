using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Orion.Data;
using Willezone.Azure.WebJobs.Extensions.DependencyInjection;

namespace Orion.Api.Bars
{
    public static class GetBar
    {
        [FunctionName("GetBar")]
        public static async Task<IActionResult> Run([HttpTrigger("GET", Route = "bars/{id:int}")] HttpRequest req, ILogger log, int id, [Inject] OrionDbContext ctx)
            => new OkObjectResult(await ctx.Bar.FindAsync(id));
    }
}