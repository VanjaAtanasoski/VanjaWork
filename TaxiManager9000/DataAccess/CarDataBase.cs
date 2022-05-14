using TaxiManager9000.DataAccess.Interface;
using TaxiManager9000.Domain.Entities;

namespace TaxiManager9000.DataAccess
{
    public class CarDatabase : Database<Car>, ICarDatabase
    {
        public CarDatabase() : base()
        {
            Seed();
        }

        private void Seed()
        {
            Insert(new Car("Ford", "SK200AB", DateTime.UtcNow.AddDays(100)));
            Insert(new Car("Mazda", "BT300RU", DateTime.UtcNow.AddDays(30)));
            Insert(new Car("KIA", "RE150BG", DateTime.UtcNow.AddDays(-40)));
            Insert(new Car("Bugatti", "BE1111BE", DateTime.UtcNow.AddDays(-200)));
           
        }
    }
}
