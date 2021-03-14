
using Microsoft.AspNetCore.Connections;
using System;
using System.Collections.Generic;

namespace DynamicProxyExample.Models
{
    public class CarContext : IDisposable
    {
        private List<Car> _cars;

        public CarContext()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id=1,
                    Vendor="Nissan",
                    Name="Skyline Gtr R34",
                    Power=600
                }, new Car
                {
                    Id=2,
                    Vendor="Hyundai",
                    Name="Sonata",
                    Power=274
                }, new Car
                {
                    Id=3,
                    Vendor="Kia",
                    Name="Rio",
                    Power=123
                }
            };
        }

        public List<Car> Cars
        {
            get
            {
                if(new Random().Next(1, 10) % 2 == 0)
                {
                    return _cars;
                }
                throw new ConnectionAbortedException(message:"Connection aborted");
            }
        }

        public void Dispose()
        {
            _cars = null;
        }
    }
}
