using System;
using System.Collections.Generic;
using System.Text;

namespace LastDance
{
    public class Student : User
    {
        public List<string> Subjects { get; set; }
        public Student(int id, string firstName, string lastName, string username,string password, Role role, List<string> subjects) : base(id, firstName, lastName,username,password,Role.Student)
        {
            Subjects = subjects;
        }

    }
}
