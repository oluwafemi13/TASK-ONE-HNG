using HNGTaskOne.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HNGTaskOne.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class DescriptionController: ControllerBase
    {
        private static Description desc = new Description();
        private static Operation op;

        public DescriptionController()
        {
            
        }


        [HttpGet(Name = "Description")]
        public IActionResult Get()
        {
            return Ok(desc);
        }

        
    }
}
