using MyBlog.Interfaces;
using MyBlog.Models;

namespace MyBlog.Services
{
    public class UserServices : IUserServices
    {
        private List<User> users;
        public UserServices()
        {
            users = new List<User>{
                new User
                {
                    Id=Guid.Parse("2fcbd8d7-5113-4def-a068-6d994300e0fc"),
                    FullName="Ruzimurod Abdunazarov Ruzinazarovich",
                    EmailAdress="Ruzimurodabdunazarov2003@mail.ru",
                    Password="P@ssw0rd",
                    Birth=DateTime.Parse("23.11.2003"),
                    Role=Roles.Administrator,
                    CreatedTime=DateTime.Now,
                    UpdateTime=DateTime.Now
                }
            };
        }
        public List<User> GetUsers()
        {
            return users;
        }
        public User GetUserById(Guid id)
        {
            return users.FirstOrDefault(i => i.Id == id) ?? new User { };
        }
        public User CreateUser(User user)
        {
            users.Add(user);
            return user;
        }
        public User UpdateUser(User newUser)
        {
            User? oldUser = users.FirstOrDefault(i => i.Id == newUser.Id);
            oldUser = new User
            {
                FullName = newUser.FullName,
                EmailAdress = newUser.EmailAdress,
                Password = newUser.Password,
                UpdateTime = DateTime.Now,
                Role = newUser.Role,
                Birth = newUser.Birth
            };
            return oldUser;
        }
        public int Count
        {
            get
            {
                return users.Count;
            }
        }
        public void DeleteUser(Guid id)
        {
            User? user = users.FirstOrDefault(i => i.Id == id) ?? new User { };
            users.Remove(user);
        }
    }
}