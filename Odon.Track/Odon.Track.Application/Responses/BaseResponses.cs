using Microsoft.AspNetCore.Mvc;

namespace Odon.Track.Application.Responses
{
    public class BaseResponses
    {
        public OkObjectResult Ok(string message)
        {
            return new OkObjectResult(message);
        }

        public OkResult Ok()
        {
            return new OkResult();
        }

        public CreatedResult Created(string message)
        {
            return new CreatedResult("", message);
        }

        public CreatedResult Created()
        {
            return new CreatedResult("", "");
        }

        public BadRequestObjectResult BadRequest(string message)
        {
            return new BadRequestObjectResult(message);
        }
    }
}
