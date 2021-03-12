
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace DynamicProxyExample.Models
{
    public class CarRepository : ICarsRepository
    {
        private readonly ILogger<CarRepository> logger;

        public CarRepository(ILogger<CarRepository> logger)
        {
            this.logger = logger;
        }

        public IEnumerable<Car> Getcars(string filter =(default))
        {
            try
            {

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public IEnumerable<Car> GetCarsSimple(string filter = (default))
        {
            throw new System.NotImplementedException();
        }
    }
}
