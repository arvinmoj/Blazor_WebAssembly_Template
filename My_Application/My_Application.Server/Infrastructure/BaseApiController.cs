using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure
{
    [ApiController]
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    public class BaseApiController : ControllerBase
    {
        public BaseApiController() : base()
        {
        }
    }
}
