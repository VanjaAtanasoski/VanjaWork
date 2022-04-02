using System;
using System.Collections.Generic;
using System.Text;

namespace LastDance
{
    public class Trainer : User
    {
        public List<Student> Students { get; set; }
         
        public Trainer(int id, string firstName, string lastName,string username, string password ,Role role, List<Student> students) : base(id, firstName, lastName,username,password, Role.Trainer)
        {
            Students = students;
            
        }
    }
}
