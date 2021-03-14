using System.Collections.Generic;

namespace DynamicProxyExample.Models
{
    public interface ICarsRepository
    {
        //IEnumerable<Car> Getcars(string filter = (default));

        IEnumerable<Car> GetCarsSimple(string filter = (default));
    }
}
