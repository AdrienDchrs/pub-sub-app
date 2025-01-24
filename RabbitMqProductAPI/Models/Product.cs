namespace RabbitMqProductAPI.Models
{
    public class Product
    {
		[JsonRequired]
        public int ProductId { get; set; }

		[JsonRequired]
        public string ProductName { get; set; }

		[JsonRequired]
        public string ProductDescription { get; set; }

		[JsonRequired]
        public int ProductPrice { get; set; }
		
		[JsonRequired]
        public int ProductStock { get; set; }
    }
}
