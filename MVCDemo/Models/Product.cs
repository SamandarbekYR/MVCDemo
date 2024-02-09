using MVCDemo.Models;

namespace MVCDemo
{
    public class Product
    {

        public int Id { get; set; }
        public int User_ID { get; set; }
        public User user { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<ProductImage> ProductImages { get; set; }

    }
}
