namespace Api.DTOs
{
    public class ProductDto
    {
         public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Url { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}