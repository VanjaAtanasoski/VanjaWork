<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Text;

public class Menager : Employee
{
    public Menager(string FirstName, string LastName, int v, Role other) : base(FirstName, LastName, 500, Role.Sales)
    {
    }
    private double Bonus { get; set; }
    public int Department;
    public Menager(int department)
    {
        Department = department;
    }

    public double AddBonus(double bonus)
    {
        return Bonus=bonus;
    }

    public override double GetSalary(double Salary, double bonus)
    {
        Salary = Salary + bonus;
        return Salary;
    }
}
=======
using System;
using System.Collections.Generic;
using System.Text;

public class Menager : Employee
{
    public Menager(string FirstName, string LastName, int v, Role other) : base(FirstName, LastName, 500, Role.Sales)
    {
    }
    private double Bonus { get; set; }
    public int Department;
    public Menager(int department)
    {
        Department = department;
    }

    public double AddBonus(double bonus)
    {
        return Bonus=bonus;
    }

    public override double GetSalary(double Salary, double bonus)
    {
        Salary = Salary + bonus;
        return Salary;
    }
}
>>>>>>> 0651355c5fd48b66e2830bf84ce55b4f912118f0
