using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryExercise1
{
    public class Contractor : Employee {
        public Contractor(string FirstName, string LastName, int v, Role other) : base(FirstName, LastName, 500, Role.Sales)
        {

        }
        public double workHours { get; set; }
        public int payPerHour { get; set; }


        /*public Contractor(double workHours, int payPerHour,)
        {
            workHours = workHours;
            payPerHour = payPerHour;

        }*/
        public override double GetSalary(double workHours, int payPerHour)
        {
            Salary = workHours * payPerHour;
            return Salary;
        }
        public int CurrentPosition(Menager Menager)
        {
            return departement;
        }
    }

}
}
/*public void FireEmployee(Employee employee)
{
    Console.WriteLine($"The director {FirstName} {LastName} has fired {employee.FirstName} {employee.LastName}");
}*/
