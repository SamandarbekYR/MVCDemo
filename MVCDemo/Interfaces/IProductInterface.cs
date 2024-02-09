namespace MVCDemo.Interfaces
{
    public interface IProductInterface
    {
        List<Product> GetAll();
        Product GetById(int id);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);
        void AddProduct(Product product);
    }
}
