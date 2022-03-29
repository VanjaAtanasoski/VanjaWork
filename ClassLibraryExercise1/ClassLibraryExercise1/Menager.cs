using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryExercise1
{
    public class Manager : Employee
    {
        public Manager(string FirstName, string LastName, int v, Role Menager) : base(FirstName, LastName, 500, Role.Sales)
        {
        }
        private double bonus { get; set; }
        public int department;
        

        public double AddBonus()
        {
            return bonus;
        }

        public override double GetSalary(double Salary, double bonus)
        {
            Salary = Salary + bonus;
            return Salary;
        }
    }
}