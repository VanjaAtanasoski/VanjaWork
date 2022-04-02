using System;
using System.Collections.Generic;
using System.Text;

namespace LastDance
{
    public enum Role
    {
        Admin,
        Trainer,
        Student
    }
    public class User
    {
        public User(int id, string firstName, string lastName,string username, string password, Role role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Username = username;
            Password = password;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

    }
}
