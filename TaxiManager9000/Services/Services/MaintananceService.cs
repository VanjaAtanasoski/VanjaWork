using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.DataAccess.Interface;
using TaxiManager9000.Domain.Entities;
using TaxiManager9000.Services.Interfaces;
using TaxiManager9000.Services.Services.Interfaces;
using TaxiManager9000.Shared;

namespace TaxiManager9000.Services.Services
{

    public class MaintananceService : IMaintenanceService
    {
        private ICarDatabase _database;

        private readonly IAuthService _authService;

        public MaintananceService()
        {
        _database = DepencyResolver.GetService<ICarDatabase>();
        }
        public void AddCar(Car car)
        {
            
        }

        public List<Car> ListAllCars(List<Car> cars)
        {
            return;
        }
    }

 

    
       
    
}
