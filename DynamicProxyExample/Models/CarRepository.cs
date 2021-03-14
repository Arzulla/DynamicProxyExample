
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicProxyExample.Models
{
    public class CarRepository : ICarsRepository
    {   
        private readonly ILogger<CarRepository> logger;

        public CarRepository(ILogger<CarRepository> logger)
        {
            this.logger = logger;
        }

        public IEnumerable<Car> Getcars(string filter = (default))
        {
            try
            {
                using var context = new CarContext();

                var cars = context.Cars.Where(e => e.Name.Contains(filter) || String.IsNullOrEmpty(filter)).ToList();

                logger.LogInformation($"Retrieving {cars.Count()} cars ");

                return cars;
            }
            catch (System.Exception)
            {
                logger.LogError("Error occured");
                throw;
            }
        }

        public IEnumerable<Car> GetCarsSimple(string filter = (default))
        {
            using var context = new CarContext();


            var cars = context.Cars.Where(e => e.Name.Contains(filter) || String.IsNullOrEmpty(filter)).ToList();

            return cars;

        }
    }
}
