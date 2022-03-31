<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibraryExercise1

public class CEO : Employee
{
    public CEO(string FirstName, string LastName, int v, Role other) : base(FirstName, LastName, 500, Role.Sales)
    {
    }
    public int SharesProperty { get; set; }
    private double SharesPrice { get; set; }

    public CEO(int sharesProperty)
    {
        SharesProperty = sharesProperty;
    }

    public double AddSharesPrice(double addShare)
    {
        return addShare=SharesPrice;
    }
    

}
=======
using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibraryExercise1

public class CEO : Employee
{
    public CEO(string FirstName, string LastName, int v, Role other) : base(FirstName, LastName, 500, Role.Sales)
    {
    }
    public int SharesProperty { get; set; }
    private double SharesPrice { get; set; }

    public CEO(int sharesProperty)
    {
        SharesProperty = sharesProperty;
    }

    public double AddSharesPrice(double addShare)
    {
        return addShare=SharesPrice;
    }
    

}
>>>>>>> 0651355c5fd48b66e2830bf84ce55b4f912118f0
