using Microsoft.AspNetCore.Mvc;

namespace Odon.Track.Application.Responses
{
    public class BaseResponses : ControllerBase
    {
        public OkObjectResult Ok(string message)
        {
            return new OkObjectResult(message);
        }

        public BadRequestObjectResult BadRequest(string message)
        {
            return new BadRequestObjectResult(message);
        }
    }
}
