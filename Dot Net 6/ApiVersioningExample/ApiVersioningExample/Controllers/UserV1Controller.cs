using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningExample.Controllers
{
    //Route for Query string parameter versioning
    [Route("api/user/[action]")]
    //Route for URI versioning
    //[Route("api/v{version:apiVersion}/user/[action]")]
    [ApiController]
    [ApiVersion("1")]
    public class UserV1Controller : ControllerBase
    {
       [HttpGet]
       public IActionResult GetInfo()
        {
            return Ok("User V1 controller");
        }
    }
}
