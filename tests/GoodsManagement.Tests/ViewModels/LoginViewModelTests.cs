using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using GoodsManagement.WPF.ViewModels;
using GoodsManagement.WPF.Services.Interfaces;

namespace GoodsManagement.Tests.ViewModels
{
    public class LoginViewModelTests
    {
        private readonly Mock<IUserService> _userServiceMock;
        private readonly LoginViewModel _loginViewModel;

        public LoginViewModelTests()
        {
            _userServiceMock = new Mock<IUserService>();
            _loginViewModel = new LoginViewModel(_userServiceMock.Object);
        }

        [Fact]
        public void LoginCommand_ValidCredentials_ShouldLoginSuccessfully()
        {
            // Arrange
            string username = "testuser";
            string password = "testpassword";
            _userServiceMock.Setup(x => x.ValidateUser(username, password)).Returns(true);

            // Act
            _loginViewModel.Username = username;
            _loginViewModel.Password = password;
            _loginViewModel.LoginCommand.Execute(null);

            // Assert
            Assert.True(_loginViewModel.IsLoggedIn);
        }

        [Fact]
        public void LoginCommand_InvalidCredentials_ShouldNotLogin()
        {
            // Arrange
            string username = "testuser";
            string password = "wrongpassword";
            _userServiceMock.Setup(x => x.ValidateUser(username, password)).Returns(false);

            // Act
            _loginViewModel.Username = username;
            _loginViewModel.Password = password;
            _loginViewModel.LoginCommand.Execute(null);

            // Assert
            Assert.False(_loginViewModel.IsLoggedIn);
        }

        [Fact]
        public void LoginCommand_EmptyUsername_ShouldNotLogin()
        {
            // Arrange
            _loginViewModel.Username = string.Empty;
            _loginViewModel.Password = "testpassword";

            // Act
            _loginViewModel.LoginCommand.Execute(null);

            // Assert
            Assert.False(_loginViewModel.IsLoggedIn);
        }

        [Fact]
        public void LoginCommand_EmptyPassword_ShouldNotLogin()
        {
            // Arrange
            _loginViewModel.Username = "testuser";
            _loginViewModel.Password = string.Empty;

            // Act
            _loginViewModel.LoginCommand.Execute(null);

            // Assert
            Assert.False(_loginViewModel.IsLoggedIn);
        }
    }
}