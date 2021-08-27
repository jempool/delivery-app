namespace DeliveryApp.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public string[] CustomerFormat()
        {
            return new string[]{ Name , PhoneNumber.ToString(), Address };
        }

        public Customer ShallowCopy()  
        {  
            return (Customer)this.MemberwiseClone();  
        }
    }
}