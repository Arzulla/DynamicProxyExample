

using DynamicProxyExample.Controllers;
using DynamicProxyExample.Models.GenericHandlers;
using Microsoft.Extensions.Logging;

namespace DynamicProxyExample.Models
{
    public class LoggingAwareQueryHandler<TQuery, TResult> : IQueryHandler<TQuery, TResult>
    {
        private readonly IQueryHandler<TQuery, TResult> _decoratedHandler;
        private readonly ILogger<CarController> _logger;

        public LoggingAwareQueryHandler(IQueryHandler<TQuery, TResult> decoratedHandler, ILogger<CarController> logger)
        {
            _decoratedHandler = decoratedHandler;
            _logger = logger;
        }

        public TResult Handle(TQuery query)
        {
            try
            {
                var result = _decoratedHandler.Handle(query);

                _logger.LogInformation("");

                return result;
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Exception occured: {ex}");

                throw;
            }
        }
    }
}
