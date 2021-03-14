using DynamicProxyExample.Models;
using DynamicProxyExample.Models.Decorators;
using DynamicProxyExample.Models.GenericHandlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace DynamicProxyExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CarController : ControllerBase
    {
        public LoggingAwareQueryHandler<string, GetCarResult> _loggingAwareQuery { get; }

        public CarController(LoggingAwareQueryHandler<string,GetCarResult> loggingAwareQuery)
        {
            _loggingAwareQuery = loggingAwareQuery;
        }


        [HttpGet("Cars")]
        public IEnumerable<object> Cars()
        {
            var handlerResult = _loggingAwareQuery.Handle("Sky");

            return handlerResult.Cars;
        }
    }
}
