using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Orion.Api.Extensions;
using Orion.Collections;
using Orion.Data;
using Orion.Data.Extensions;
using Orion.Entities;
using Willezone.Azure.WebJobs.Extensions.DependencyInjection;

namespace Orion.Api.Foos
{
    public static class GetFoos
    {
        [FunctionName("GetFoos")]
        public static async Task<IActionResult> Run([HttpTrigger("GET", Route = "foos")] HttpRequest req, ILogger log, [Inject] OrionDbContext ctx)
        {
            var sortProperty = req.Query.GetValueOrDefault("sortProperty", nameof(Foo.Id));
            var sortDirection = req.Query.GetValueOrDefault<SortDirection>("sortDirection");
            var pageIndex = req.Query.GetValueOrDefault("pageIndex", 0);
            var pageSize = req.Query.GetValueOrDefault("pageSize", 20);

            // something like...
            // TODO [Query] PageOptions options

            return new OkObjectResult(await ctx.Foo.SortBy(sortProperty, sortDirection).ToPageAsync(pageIndex, pageSize));
        }
    }
}