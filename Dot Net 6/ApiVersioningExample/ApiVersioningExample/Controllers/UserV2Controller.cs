using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningExample.Controllers
{ 
    //Route for Query string parameter versioning
    [Route("api/user/[action]")]
    //Route for URI versioning
    //[Route("api/v{version:apiVersion}/user/[action]")]
    [ApiController]
    [ApiVersion("2")]
    public class UserV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            string dd = "User V2 controller 1";
            return Ok(dd);
        }
    }
}
