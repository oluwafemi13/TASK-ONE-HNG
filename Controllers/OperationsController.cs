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



        //[HttpPost( Name = "Operations")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult Operations()
        {
            char operation = '+';
            int result = 0;
            int x = 5;
            int y = 3;
           
            
           
            if(operation == '+')
            {
                object operationtype = OperationType.Addition;
                result = x + y;
                string final = string.Join(',', response.SlackUsername, result, operationtype);

                return Ok(final);
            }
            else if(operation == '-')
            {
                object operationtype = OperationType.Subtraction;
                result = x - y;
                string final = string.Join(',', response.SlackUsername, result, operationtype);
                return Ok(final);
            }
            else if (operation == '*')
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
