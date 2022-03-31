<<<<<<< HEAD
﻿using System;

namespace ClassLibraryExercise1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }

        public Role Role { get; set; }


        public Employee(string firstName, string lastName, double salary, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = role;

        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }


}
=======
﻿using System;

namespace ClassLibraryExercise1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }

        public Role Role { get; set; }


        public Employee(string firstName, string lastName, double salary, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = role;

        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }


}
>>>>>>> 0651355c5fd48b66e2830bf84ce55b4f912118f0
