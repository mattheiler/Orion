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
        public static async Task<IActionResult> GetStudents([HttpTrigger("GET", Route = "students")] HttpRequest req, ILogger log)
        {
            using (var context = new OrionDbContext())
            {
                return new OkObjectResult(await context.Foo.ToListAsync());
            }
        }


        [FunctionName("GetFoo")]
        public static async Task<IActionResult> GetStudent([HttpTrigger("GET", Route = "students/{id:int}")] HttpRequest req, ILogger log, int id)
        {
            using (var context = new OrionDbContext())
            {
                return new OkObjectResult(await context.Foo.FindAsync(id));
            }
        }
    }
}