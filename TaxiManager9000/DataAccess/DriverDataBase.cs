using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.DataAccess.Interface;
using TaxiManager9000.Domain.Entities;
using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.DataAccess
{
    public class DriverDatabase : Database<Driver>, IDriverDatabase
    {
        public DriverDatabase() : base()
        {
            Seed();
        }
        public void Seed()
        {
            Insert(AutoIncrementId(new Driver(Shift.Afternoon, "Miki", "Miki", DateTime.UtcNow.AddDays(400), DateTime.UtcNow.AddDays(250),new Car("Mazda","CX-75",DateTime.UtcNow.AddDays(50)))));
            Insert(AutoIncrementId(new Driver(Shift.Afternoon, "Bojan", "Boki", DateTime.UtcNow.AddDays(130), DateTime.UtcNow.AddDays(330))));
            Insert(AutoIncrementId(new Driver(Shift.Afternoon,"Vanja", "Atanasoski", DateTime.UtcNow.AddDays(200), DateTime.UtcNow.AddDays(230))));
            Insert(AutoIncrementId(new Driver(Shift.Afternoon,"Cvetko", "Cvetki", DateTime.UtcNow.AddDays(300), DateTime.UtcNow.AddDays(150))));
         }
    }
}
