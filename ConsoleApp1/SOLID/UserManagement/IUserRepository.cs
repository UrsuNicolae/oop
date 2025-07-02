namespace ConsoleApp1.SOLID.UserManagement
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
    }
}
