using DynamicProxyExample.Models.GenericHandlers;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace DynamicProxyExample.Models
{
    public class CarRepositoryQueryHandler : IQueryHandler<string, GetCarResult>
    {
        private readonly ILogger<CarRepositoryQueryHandler> _logger;

        public CarRepositoryQueryHandler(ILogger<CarRepositoryQueryHandler> logger)
        {
            _logger = logger;
        }

        public GetCarResult Handle(string query)
        {
            using var context = new CarContext();

            var cars = context.Cars.Where(e => e.Name.Contains(query) || string.IsNullOrEmpty(query)).ToList() ;

            return new GetCarResult(cars);
        }
    }
}
