using Microsoft.AspNetCore.Mvc;

namespace Odon.Track.Application.Responses
{
    public class BaseResponses
    {
        public OkObjectResult Ok(object message)
        {
            return new OkObjectResult(message);
        }

        public OkResult Ok()
        {
            return new OkResult();
        }

        public OkObjectResult Updated()
        {
            return new OkObjectResult(new { message = "modified"});
        }

        public CreatedResult Created(object message)
        {
            return new CreatedResult("", message);
        }

        public CreatedResult Created()
        {
            return new CreatedResult("", new
            {
                message = "created"
            });
        }

        public BadRequestObjectResult BadRequest(object message)
        {
            return new BadRequestObjectResult(new { message });
        }
    }
}
