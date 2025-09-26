namespace GoodsManagement.WPF.Services.Interfaces
{
    public interface IUserService
    {
        User GetUserById(int userId);
        IEnumerable<User> GetAllUsers();
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
        User Authenticate(string username, string password);
    }
}