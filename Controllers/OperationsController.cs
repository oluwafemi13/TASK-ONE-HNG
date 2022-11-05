using HNGTaskOne.Model;
using HNGTaskOne.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;

namespace HNGTaskOne.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [Produces("application/json")]
    public class OperationsController: ControllerBase
    {
        private static Operation op;
        Response response = new Response();



        [HttpPost("[action]/{x}/{y}/{operation}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult Operations([FromBody]int x, int y, string operation)
        {
             operation = "Addition".ToLower();
            int result = 0;
             x = 5;
             y = 3;
           
            
           
            if(operation == "Addition".ToLower())
            {
                object operationtype = OperationType.Addition;
                result = x + y;
                string final = string.Join(',', response.SlackUsername, result, operationtype);

                return Ok(final);
            }
            else if(operation == "subtraction".ToLower())
            {
                object operationtype = OperationType.Subtraction;
                result = x - y;
                string final = string.Join(',', response.SlackUsername, result, operationtype);
                return Ok(final);
            }
            else if (operation == "multiplication".ToLower())
            {
                object operationtype = OperationType.Subtraction;
                result = x * y;
                string final = string.Join(',', response.SlackUsername, result, operationtype);
                return Ok(final);
            }


          return Ok(result);



        }
    }
}
