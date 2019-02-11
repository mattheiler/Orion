using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Orion.Data;

namespace Orion.Api.Foos
{
    public static class FooFunctions
    {
        [FunctionName("GetFoos")]
        public static async Task<IActionResult> GetFoos([HttpTrigger("GET", Route = "foos")] HttpRequest req, ILogger log)
        {
            // TODO Authorization
            // https://github.com/Azure/azure-functions-host/issues/33

            // TODO Dependency Injection
            // https://github.com/Azure/Azure-Functions/issues/299
            // https://github.com/Azure/Azure-Functions/issues?utf8=%E2%9C%93&q=is%3Aissue+is%3Aopen+identity
            // https://blog.wille-zone.de/post/azure-functions-dependency-injection/
            // https://blog.wille-zone.de/post/azure-functions-proper-dependency-injection/

            using (var context = new OrionDbContext())
            {
                return new OkObjectResult(await context.Foo.ToListAsync());
            }
        }

        [FunctionName("GetFoo")]
        public static async Task<IActionResult> GetFoo([HttpTrigger("GET", Route = "foos/{id:int}")] HttpRequest req, ILogger log, int id)
        {
            using (var context = new OrionDbContext())
            {
                return new OkObjectResult(await context.Foo.FindAsync(id));
            }
        }
    }
}