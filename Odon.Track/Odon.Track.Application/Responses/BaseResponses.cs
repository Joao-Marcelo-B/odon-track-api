using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Odon.Track.Application.Responses
{
    public class BaseResponses
    {
        public OkObjectResult Ok(object message)
        {
            return new OkObjectResult(message);
        }

        public NoContentResult NoContent()
        {
            return new NoContentResult();
        }

        public FileContentResult FileResponse(byte[] file, string contentType)
        {
            return new FileContentResult(file, contentType);
        }

        public OkObjectResult Deleted()
        {
            return new OkObjectResult(new { message = "deleted" });
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
            Console.WriteLine($"BadRequest: {message}");
            return new BadRequestObjectResult(new { message });
        }
    }
}
