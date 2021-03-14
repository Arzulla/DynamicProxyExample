
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace DynamicProxyExample.Models.Decorators
{
    public class CarRepositoryDecorator : ICarsRepository
    {
        private readonly ICarsRepository _carsRepository;
        private readonly ILogger<CarRepositoryDecorator> _logger;

        public CarRepositoryDecorator(ICarsRepository carsRepository, ILogger<CarRepositoryDecorator> logger)

        {
            _carsRepository = carsRepository;
            _logger = logger;
        }

        public IEnumerable<Car> GetCarsSimple(string filter = null)
        {
            _logger.LogInformation("Some information");

            try
            {
                var result = _carsRepository.GetCarsSimple(filter);

                var cars = result.ToList();

                _logger.LogInformation($"Count is {cars.Count()}");

                return cars;
            }
            catch (System.Exception ex)
            {
                _logger.LogError("Error occured on cars");
                throw;
            }
        }
    }
}
