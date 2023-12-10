namespace Api.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public List<Product> Products { get; set; }

    }
}