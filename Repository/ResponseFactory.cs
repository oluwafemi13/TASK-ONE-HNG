using HNGTaskOne.Model;

namespace HNGTaskOne.Repository
{
    public class ResponseFactory
    {
       
            public Response ExecutionResponse<T>(string username, OperationType operation , int result) 
            {
            //{ “slackUsername”: String, "operation_type" : Enum. value, “result”: Integer }

            return new Response
                {
                    SlackUsername = username,
                    Operation= operation,
                    result = result
   
                };
            }

        }
    }
