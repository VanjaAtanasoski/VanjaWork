using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Entities
{
    public class Driver
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Shift Shift { get; set; }

        public Car car { get; set; }

        public Driver(int id, string firstName, string lastName, Shift shift)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Shift = shift;
            
        }

    }
}
