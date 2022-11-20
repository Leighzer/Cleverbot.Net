using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Cleverbot.Net.MockApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CleverbotController : ControllerBase
    {

        private readonly ILogger<CleverbotController> _logger;

        public CleverbotController(ILogger<CleverbotController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getreply")]
        public IActionResult GetExample()
        {
            string exampleResponseJson = System.IO.File.ReadAllText("ExampleResponse.json");

            return Content(exampleResponseJson, "application/json");
        }

        [HttpGet("gettest")]
        public IActionResult GetTest()
        {
            string exampleResponseJson = System.IO.File.ReadAllText("TestResponse.json");

            return Content(exampleResponseJson, "application/json");
        }
    }
}