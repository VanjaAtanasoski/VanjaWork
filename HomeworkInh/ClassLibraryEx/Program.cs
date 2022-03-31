using ClassLibraryExercise1;

namespace ClassLibraryEx
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson person = new SalesPerson("Vanja","Atanasoski",600,Role.Other);
            person.GetSalary();
        }
    }
}
