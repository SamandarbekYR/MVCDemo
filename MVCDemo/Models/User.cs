namespace MVCDemo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Created_AT { get; set; } = DateTime.Now;
        public List<Product> Products { get; set; }
    }
}
