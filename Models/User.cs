namespace MyBlog.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? EmailAdress { get; set; }
        public string? Password { get; set; }
        public DateTime Birth { get; set; }
        public Roles Role { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreatedTime { get; set; }
    }
    public enum Roles
    {
        Administrator,
        CreatedTest,
        User
    }
}