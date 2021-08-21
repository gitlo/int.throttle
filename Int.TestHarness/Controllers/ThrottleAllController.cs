using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Int.TestHarness.Controllers
{    
    [ApiController]
    [Route("[controller]")]
    public class ThrottleAllController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int retrycount)
        {
            if (retrycount > 2) return Ok();
            Response.Headers.Add("Retry-After", "11");
            return StatusCode(429);
        }

        [HttpPost]
        public IActionResult Post(int retrycount)
        {
            if (retrycount > 2) return Ok();
            Response.Headers.Add("Retry-After", "11");
            return StatusCode(429);
        }

        [HttpPatch]
        public IActionResult Patch(int retrycount)
        {
            if (retrycount > 2) return Ok();
            Response.Headers.Add("Retry-After", "11");
            return StatusCode(429);
        }
    }
}
