using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.DataAccess;
using TaxiManager9000.DataAccess.Interface;
using TaxiManager9000.Domain.Entities;
using TaxiManager9000.Services.Services.Interfaces;
using TaxiManager9000.Shared;

namespace TaxiManager9000.Services.Services
{
    public class ManagerService : IManagerSerevice
    {
        private readonly IDriverDatabase _database;
        public ManagerService()
        {
            _database = DependencyResolver.GetService<IDriverDatabase>();
        }
        public List<Driver> ListAllDrivers()
        {
            List<Driver> drivers = _database.GetAll();

            return drivers;
        }

        public void TaxiLicense()
        {
           
                List<Driver> drivers = _database.GetAll();

                foreach (Driver driver in drivers)
                {
                    if (!driver.IsLicensePlateExpired())
                    {
                        if (driver.LicensePlateExpiryDate.AddDays(90)<DateTime.Now)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            driver.GetInfo();
                            Console.ResetColor();
                        }
                        else
                        {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        driver.GetInfo();
                        Console.ResetColor();
                        }
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        driver.GetInfo();
                        Console.ResetColor();
                    }
                }

            
        }
    }
}
