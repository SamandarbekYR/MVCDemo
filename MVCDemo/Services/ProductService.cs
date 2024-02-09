using Microsoft.EntityFrameworkCore;
using MVCDemo.Data;
using MVCDemo.Interfaces;

namespace MVCDemo.Services
{
    public class ProductService : IProductInterface
    {
        AppDBContext dbContext;
        public ProductService(){
            dbContext = new AppDBContext();
            }
        public void AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();    
        }

        public void DeleteProduct(int id)
        {
            Product nomi = dbContext.Products.FirstOrDefault(x => x.Id == id)!;
            if (nomi != null)
            {
                dbContext.Products.Remove(nomi);
                dbContext.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return dbContext.Products.FirstOrDefault(x => x.Id == id)!;
        }

        public void UpdateProduct(Product product)
        {
            dbContext.Products.Update(product);
            dbContext.SaveChanges();
        }
    }
}
