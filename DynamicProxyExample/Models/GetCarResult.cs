
using DynamicProxyExample.Models.Attributes;
using System.Collections.Generic;

namespace DynamicProxyExample.Models
{
    public class GetCarResult
    {
        [LogCount("Number of cars")]
        public IEnumerable<Car> Cars { get; }

        public GetCarResult(IEnumerable<Car> cars)
        {
            Cars = cars;
        }
    }
}
