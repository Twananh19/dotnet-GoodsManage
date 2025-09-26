using System.Collections.Generic;
using System.Linq;
using GoodsManagement.WPF.Data.Repositories.Interfaces;
using GoodsManagement.WPF.Models;
using GoodsManagement.WPF.Services.Interfaces;

namespace GoodsManagement.WPF.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserById(int userId)
        {
            return _userRepository.GetById(userId);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll().ToList();
        }

        public void AddUser(User user)
        {
            _userRepository.Add(user);
            _userRepository.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
            _userRepository.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var user = _userRepository.GetById(userId);
            if (user != null)
            {
                _userRepository.Delete(user);
                _userRepository.SaveChanges();
            }
        }

        public User Authenticate(string username, string password)
        {
            var user = _userRepository.GetByUsername(username);
            if (user != null && PasswordHelper.VerifyPassword(password, user.PasswordHash))
            {
                return user;
            }
            return null;
        }
    }
}