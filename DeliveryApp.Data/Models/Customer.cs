namespace DeliveryApp.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }

        public string[] ToArrString()
        {
            return new string[]{ Name , PhoneNumber.ToString(), Address };
        }
    }    
}