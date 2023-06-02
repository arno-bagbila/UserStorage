using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BeersApiAdapter.BeersApi;
using BeersApiAdapter.DTOs;
using BeersApiAdapter.Services;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace BeersApiAdapter.Tests.Services
{
   [TestFixture]
   public class AdapterTests
   {
      #region Data

      private Adapter _sut;
      private Mock<IApiClient> _mockApiClient;

      #endregion

      [SetUp]
      public void BeforeEach()
      {
         _mockApiClient = new Mock<IApiClient>();
         _sut = new Adapter(_mockApiClient.Object);
      }

      [Test]
      public async Task CreateUser_WithValidInput_ReturnUserCreated()
      {
         //arrange
         var userToCreate = new User
         {
            Email = "email@test.com",
            UId = Guid.NewGuid(),
            RoleName = "BeersApiReadOnly",
            FirstName = "username"
         };
         
         var createdUser = new User
         {
            Email = userToCreate.Email,
            UId = userToCreate.UId,
            RoleName = userToCreate.RoleName,
            FirstName = userToCreate.FirstName
         };

         _mockApiClient.Setup(x => x.CreateUserAsync(userToCreate)).ReturnsAsync(createdUser);
         
         //act
         var result = await _sut.CreateUser(userToCreate);
         
         //assert
         result.Should().NotBe(null);
         result.Email.Should().Be(userToCreate.Email);
         result.UId.Should().Be(userToCreate.UId);
         result.RoleName.Should().Be(userToCreate.RoleName);
         result.FirstName.Should().Be(userToCreate.FirstName);
      }
   }
}
