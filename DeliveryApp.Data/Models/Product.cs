namespace DeliveryApp.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Details { get; set; }
        public string[] ToArrString()
        {
            return new string[]
            {
                Name,
                Price.ToString(),
                Details,
            };
        }
    }    
}