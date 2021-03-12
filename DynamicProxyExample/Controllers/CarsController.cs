using Microsoft.AspNetCore.Mvc;

namespace DynamicProxyExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CarsController:ControllerBase
    {

    }
}
