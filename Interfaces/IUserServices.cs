using MyBlog.Models;

namespace MyBlog.Interfaces
{
    public interface IUserServices
    {
        public List<User> GetUsers();
        public User GetUserById(Guid id);
        public User CreateUser(User user);
        public User UpdateUser(User newUser);
        public int Count { get; }
        public void DeleteUser(Guid id);
    }
}