using MVCDemo.Data;
using MVCDemo.Interfaces;
using MVCDemo.Models;

namespace MVCDemo.Services
{
    public class UserService : IUserInterface
    {
        AppDBContext dBContext;
        public UserService() {
            dBContext = new();
        }
        public void AddUser(User user)
        {
            dBContext.Users.Add(user);
            dBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            User nomi = dBContext.Users.FirstOrDefault(x => x.Id == id);
            if (nomi != null)
            {
                dBContext.Users.Remove(nomi);
                dBContext.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            return dBContext.Users.ToList();
        }

        public User GetById(int id)
        {
            return dBContext.Users.FirstOrDefault(x => x.Id == id)!;
        }

        public void Update(User user)
        {
            dBContext.Users.Update(user);
        }
    }
}
