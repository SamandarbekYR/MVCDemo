using MVCDemo.Models;

namespace MVCDemo.Interfaces
{
    public interface IUserInterface
    {
        List<User> GetAll();
        User GetById(int id);
        void Delete(int id);
        void Update(User user);
        void AddUser(User user);
    }
}
