using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManager9000.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        DateTime LicensePlateExpieryDate { get; set; }
        Driver Driver { get; set; }



        public Car(int id, string model, string licensePlate, DateTime licensePlateExpieryDate)
        {
            Id = id;
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpieryDate = licensePlateExpieryDate;
        }
    }
}
