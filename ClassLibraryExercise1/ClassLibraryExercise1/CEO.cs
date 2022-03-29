using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibraryExercise1
{
    public class CEO : Employee
    {
        public CEO(string FirstName, string LastName, int v, Role other) : base(FirstName, LastName, 500, Role.Sales)
        {
        }
        public int sharesProperty { get; set; }
        private double sharesPrice { get; set; }

      /*  public CEO(int sharesProperty)
        {
           sharesProperty = sharesProperty;
        }*/

        public double AddSharesPrice(double sharesPrice)
        {
            return sharesPrice;
        }


    }
}
