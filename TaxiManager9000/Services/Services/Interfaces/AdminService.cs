using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.DataAccess;
using TaxiManager9000.Domain.Entities;
using TaxiManager9000.Shared;

namespace TaxiManager9000.Services.Services.Interfaces
{
    public class AdminService : IAdminService
    {
        private readonly IUserDataBase _database;

        public AdminService()
        {
            _database = DependencyResolver.GetService<IUserDataBase>();
        }
        public bool CheckPassword(User user)
        {
           if(user.Password.Length<5 || user.UserName.Length < 5)
            {
                return false;
            }
            else
            {
                char[] characters = user.Password.ToCharArray();
                int minDigit = 1;
                int digit = 0;
                foreach (char enteredCharacters in characters)
                {
                    if (char.IsDigit(enteredCharacters))
                    {
                        digit++;
                    }
                }
                if (digit < minDigit)
                {
                    return false;
                }
                return true;

            }
        }

        public void CreateUser(User user)
        {
            if (CheckPassword(user))
            {
                _database.Insert(user);
            }
        }
    }
}
