using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Orion.Collections;
using Orion.Data;
using Orion.Data.Extensions;
using Willezone.Azure.WebJobs.Extensions.DependencyInjection;

namespace Orion.Api.Foos
{
    public static class GetFoos
    {
        [FunctionName("GetFoos")]
        public static async Task<IActionResult> Run([HttpTrigger("GET", Route = "foos")] HttpRequest req, ILogger log, [Inject] OrionDbContext ctx)
        {
            var sortPropertyQuery = (string) req.Query["sortProperty"];
            var sortProperty = sortPropertyQuery ?? nameof(Foo.Id);

            var sortDirectionQuery = (string) req.Query["sortDirection"];
            var sortDirection = sortDirectionQuery != null ? (SortDirection?) Enum.Parse(typeof(SortDirection), sortDirectionQuery, true) : null;
            
            var pageIndexQuery = (string) req.Query["pageIndex"];
            var pageIndex = pageIndexQuery != null ? int.Parse(pageIndexQuery) : 0;

            var pageSizeQuery = (string) req.Query["pageSize"];
            var pageSize = pageSizeQuery != null ? int.Parse(pageSizeQuery) : 0;

            // TODO req.Query["sortProperty"].GetValueOrDefault(nameof(Foo.Id));
            // TODO req.Query["sortDirection"].GetValueOrDefault<SortDirection>();
            // TODO req.Query["pageIndex"].GetValueOrDefault<int>(0);
            // TODO req.Query["pageSize"].GetValueOrDefault<int>(20);

            // something like...
            // TODO [Query] PageOptions options

            return new OkObjectResult(await ctx.Foo.SortBy(sortProperty, sortDirection).ToPageAsync(pageIndex, pageSize));
        }
    }
}