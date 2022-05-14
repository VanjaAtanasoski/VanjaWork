using Newtonsoft.Json;
using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Entities
{
    public class Driver : BaseEntity
    {
        [JsonConstructor]
        
        public Driver(Shift shift, string firstName, string lastName, DateTime license, DateTime licensePlateExpiryDate, Car? car = null) :base()
        {
            Id = -1;
            Shift = shift;
           
            FirstName = firstName;
            LastName = lastName;  
            License = license;
            Car = car;
            LicensePlateExpiryDate = licensePlateExpiryDate;
        }

        public Shift Shift { get; set; }
      

        public string FirstName{get;set;}
        public string LastName { get; set; }
        public Car Car { get; set; }
        public DateTime License { get; set; }
        public DateTime LicensePlateExpiryDate { get; private set; }

        public void GetInfo()
        {
            Console.WriteLine($"{FirstName}- {LastName}-{LicensePlateExpiryDate}");
        }
        public bool IsLicensePlateExpired()
        {
            if (LicensePlateExpiryDate < DateTime.Now)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"{Id} - {FirstName} - {LastName}";
        }
    }
}
