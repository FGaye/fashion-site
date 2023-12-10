using Api.Entities;

namespace Api.DTOs
{
    public class CartDto
    {
        public User UserId { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }
    }
}