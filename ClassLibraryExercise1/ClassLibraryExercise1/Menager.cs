using System;
using System.Collections.Generic;
using System.Text;

public class Manager : Employee
{
    public Manager(string FirstName, string LastName, int v, Role other) : base(FirstName, LastName, 500, Role.Sales)
    {
    }
    private double bonus { get; set; }
    public int department;
    public Menager(int department)
    {
        department = department;
    }

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
