using System;
using System.Collections.Generic;
using System.Text;

namespace LastDance
{
    public class Admin : User
    {   
        public List<User> Users { get; set; }

        public Admin(int id, string firstName, string lastName,string username,string password, Role role) : base(id, firstName, lastName, username,password,Role.Admin)
        {
           
        }
        

    }
     
}
