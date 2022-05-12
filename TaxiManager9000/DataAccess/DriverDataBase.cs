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
            _items.AddRange(new List<Driver>()
            {
                new Driver(Shift.Afternoon,"Vanja","Atanasoski",new Car("mazda","CX-2999", DateTime.UtcNow.AddDays(100)), DateTime.UtcNow.AddDays(200), DateTime.UtcNow.AddDays(230)),
                new Driver(Shift.Afternoon,"Miki","Miki",new Car("opel","EZ-2999", DateTime.UtcNow.AddDays(50)), DateTime.UtcNow.AddDays(400), DateTime.UtcNow.AddDays(100)),
                new Driver(Shift.Afternoon,"Bojan","Boki",new Car("reno","DH-2999", DateTime.UtcNow.AddDays(70)), DateTime.UtcNow.AddDays(300), DateTime.UtcNow.AddDays(130)),
                new Driver(Shift.Afternoon,"Cvetko","Cvetki",new Car("mercedes","VH-2999", DateTime.UtcNow.AddDays(400)), DateTime.UtcNow.AddDays(300), DateTime.UtcNow.AddDays(150))
            });
        }
    }
}
