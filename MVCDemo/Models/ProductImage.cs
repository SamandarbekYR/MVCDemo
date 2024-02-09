namespace MVCDemo.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int Product_ID {  get; set; }
        public Product Product { get; set; }
        public string URL { get; set; }
    }
}
