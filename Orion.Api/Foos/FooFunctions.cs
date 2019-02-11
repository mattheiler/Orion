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
            // TODO auth?
            // TODO di?

            using (var context = new OrionDbContext())
            {
                return new OkObjectResult(await context.Foo.ToListAsync());
            }
        }

        [FunctionName("GetFoo")]
        public static async Task<IActionResult> GetFoo([HttpTrigger("GET", Route = "foos/{id:int}")] HttpRequest req, ILogger log, int id)
        {
            // TODO auth?
            // TODO di?

            using (var context = new OrionDbContext())
            {
                return new OkObjectResult(await context.Foo.FindAsync(id));
            }
        }
    }
}