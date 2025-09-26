using System.Collections.ObjectModel;
using System.Windows.Input;
using GoodsManagement.WPF.Models;
using GoodsManagement.WPF.Services.Interfaces;
using GoodsManagement.WPF.Utils.Commands;

namespace GoodsManagement.WPF.ViewModels
{
    public class UserManagementViewModel : BaseViewModel
    {
        private readonly IUserService _userService;
        private ObservableCollection<User> _users;
        private User _selectedUser;

        public UserManagementViewModel(IUserService userService)
        {
            _userService = userService;
            LoadUsers();
            AddUserCommand = new RelayCommand(AddUser);
            EditUserCommand = new RelayCommand(EditUser, CanEditUser);
            DeleteUserCommand = new RelayCommand(DeleteUser, CanDeleteUser);
        }

        public ObservableCollection<User> Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddUserCommand { get; }
        public ICommand EditUserCommand { get; }
        public ICommand DeleteUserCommand { get; }

        private void LoadUsers()
        {
            Users = new ObservableCollection<User>(_userService.GetAllUsers());
        }

        private void AddUser()
        {
            // Logic to add a new user
        }

        private void EditUser()
        {
            // Logic to edit the selected user
        }

        private void DeleteUser()
        {
            // Logic to delete the selected user
        }

        private bool CanEditUser()
        {
            return SelectedUser != null;
        }

        private bool CanDeleteUser()
        {
            return SelectedUser != null;
        }
    }
}