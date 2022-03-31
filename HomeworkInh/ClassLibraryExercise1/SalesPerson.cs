using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryExercise1
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string FirstName, string LastName, int v, Role other) : base(FirstName, LastName, 500, Role.Sales)
        {
        }

        private double _successSaleRevenue;
       


       public double AddSuccessRevenue(double Revenue)
       {
            return _successSaleRevenue = Revenue;
        }

        public override double GetSalary()
        {
            if (Salary == 2000)
            {
                Salary = Salary + 500;
            }
            if (Salary > 2000 && Salary < 5000)
            {
                Salary = Salary + 1000;
            }
            if (Salary > 5000)
            {
                Salary = Salary + 1500;
            }
            return Salary;
        }
    }
}
