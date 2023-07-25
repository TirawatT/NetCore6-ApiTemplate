using Microsoft.AspNetCore.Mvc;

namespace NetCoreApiTemplate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {

        public HealthController()
        {
        }

        [HttpGet]
        public ActionResult Get()
        {
            var res = "";
            return Ok(res);
        }
    }
}