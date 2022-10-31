using HNGTaskOne.Model;
using Microsoft.AspNetCore.Mvc;

namespace HNGTaskOne.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class DescriptionController: ControllerBase
    {
        private static Description desc = new Description();





        [HttpGet(Name = "GetDescription")]
        public IActionResult Get()
        {
            return Ok(desc);
        }
    }
}
