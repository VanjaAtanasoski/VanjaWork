using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Entities
{
    internal class Admin : User
    {
        public Admin(string userName, string password, Role role) : base(userName, password, role)
        {
        }
    }
}
