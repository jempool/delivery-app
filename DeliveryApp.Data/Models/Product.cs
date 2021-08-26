namespace DeliveryApp.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Details { get; set; }
        public int Quantity  { get; set; }
        public string[] ToArrString()
        {
            return new string[]
            {
                Name + Details,
                Quantity.ToString(),
                Price.ToString(),
            };
        }

        public Product ShallowCopy()  
        {  
            return (Product)this.MemberwiseClone();  
        }
    }    
}