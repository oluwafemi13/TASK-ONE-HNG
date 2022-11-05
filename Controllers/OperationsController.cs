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


        [HttpPost]
        [Route("api/Operations/Operation")]
        //[HttpPost("[action]/{x}/{y}/{operation}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult Operation([FromBody] Operation operation )
        {
             //operation = "Addition".ToLower();
            int result = 0;
            /* x = 5;
             y = 3;*/
           
            
           
            if(operation.operations == OperationType.Addition)
            {
                object operationtype = OperationType.Addition;
                operation.result = operation.x + operation.y;
                
                //string final = string.Join(',', response.SlackUsername, result, operationtype);

                return Ok(operation);
            }
            else if (operation.operations == OperationType.Subtraction)
            {
                object operationtype = OperationType.Subtraction;
                operation.result = operation.x - operation.y;

                //string final = string.Join(',', response.SlackUsername, result, operationtype);

                return Ok(operation);
            }
            else if (operation.operations == OperationType.Multiplication)
            {
                object operationtype = OperationType.Multiplication;
                operation.result = operation.x * operation.y;

                //string final = string.Join(',', response.SlackUsername, result, operationtype);

                return Ok(operation);
            }
            /*else if(operation == "subtraction".ToLower())
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
*/

          return Ok(operation);



        }
    }
}
