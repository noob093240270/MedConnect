using Microsoft.AspNetCore.Mvc;

namespace Diploma.Areas.Appointments
{
    public class AppointmentsController
    {
        [ApiController]
        [Route("api/[controller]")]
        public class HelloController : ControllerBase
        {
            [HttpGet]
            public IActionResult Get()
            {
                return Ok("Привет от API!");
            }
        }
    }
}
