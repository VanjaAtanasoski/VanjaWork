using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.DataAccess.Interface;
using TaxiManager9000.Domain.Entities;

namespace TaxiManager9000.DataAccess
{
    public class CarDataBase : ICarDataBase
    {
        private readonly List<Car> _cars;
      

        public CarDataBase()
        {
            _cars =new List<Car>();
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);

        }
        public List<Car> ListCars()
        {
            return _cars;
        }
    }
}
