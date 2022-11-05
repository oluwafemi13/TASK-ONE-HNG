using HNGTaskOne.Model;
using HNGTaskOne.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;

namespace HNGTaskOne.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class OperationsController: ControllerBase
    {
        private static Operation op;

        private readonly ResponseFactory _responseFactory;

        public OperationsController(ResponseFactory responseFactory)
        {
            _responseFactory = responseFactory; 
        }

        [HttpPost("[action]/{x}/{y}", Name = "Operation")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public ActionResult<string> operation([FromBody] int x, char operation, int y)
        {
            int result = 0;
            Response response = new Response();
            op = new Operation()
            {
                x = x,
                y = y,

            };
           
            if(operation == '+')
            {
                object operationtype = OperationType.Addition;
                result = x + y;
                string final = string.Join(',', response.SlackUsername, operationtype, result);

                return Ok(final);
            }
            else if(operation == '-')
            {
                object operationtype = OperationType.Subtraction;
                result = x - y;
                string final = string.Join(',', response.SlackUsername, operationtype, result);
                return Ok(final);
            }
            else if (operation == '*')
            {
                object operationtype = OperationType.Subtraction;
                result = x * y;
                string final = string.Join(',', response.SlackUsername, operationtype, result);
                return Ok(final);
            }


          return NoContent();



        }
    }
}
