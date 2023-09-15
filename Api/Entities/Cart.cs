namespace Api.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }

        public User UserId { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }

    }
}