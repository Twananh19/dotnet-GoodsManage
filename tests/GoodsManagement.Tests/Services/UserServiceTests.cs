using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using GoodsManagement.WPF.Models;
using GoodsManagement.WPF.Services.Interfaces;
using GoodsManagement.WPF.Services;

namespace GoodsManagement.Tests.Services
{
    [TestClass]
    public class UserServiceTests
    {
        private Mock<IUserRepository> _userRepositoryMock;
        private IUserService _userService;

        [TestInitialize]
        public void Setup()
        {
            _userRepositoryMock = new Mock<IUserRepository>();
            _userService = new UserService(_userRepositoryMock.Object);
        }

        [TestMethod]
        public void AddUser_ShouldAddUser_WhenUserIsValid()
        {
            // Arrange
            var user = new User { Username = "testuser", PasswordHash = "hashedpassword", Role = "User" };
            _userRepositoryMock.Setup(repo => repo.Add(It.IsAny<User>())).Verifiable();

            // Act
            _userService.AddUser(user);

            // Assert
            _userRepositoryMock.Verify(repo => repo.Add(It.Is<User>(u => u.Username == "testuser")), Times.Once);
        }

        [TestMethod]
        public void GetUser_ShouldReturnUser_WhenUserExists()
        {
            // Arrange
            var userId = 1;
            var user = new User { UserId = userId, Username = "testuser", PasswordHash = "hashedpassword", Role = "User" };
            _userRepositoryMock.Setup(repo => repo.GetById(userId)).Returns(user);

            // Act
            var result = _userService.GetUser(userId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("testuser", result.Username);
        }

        [TestMethod]
        public void GetAllUsers_ShouldReturnAllUsers()
        {
            // Arrange
            var users = new List<User>
            {
                new User { UserId = 1, Username = "user1" },
                new User { UserId = 2, Username = "user2" }
            };
            _userRepositoryMock.Setup(repo => repo.GetAll()).Returns(users);

            // Act
            var result = _userService.GetAllUsers();

            // Assert
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void DeleteUser_ShouldRemoveUser_WhenUserExists()
        {
            // Arrange
            var userId = 1;
            _userRepositoryMock.Setup(repo => repo.Delete(userId)).Verifiable();

            // Act
            _userService.DeleteUser(userId);

            // Assert
            _userRepositoryMock.Verify(repo => repo.Delete(userId), Times.Once);
        }
    }
}