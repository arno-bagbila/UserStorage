using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BeersApiAdapter.BeersApi;
using BeersApiAdapter.DTOs;
using BeersApiAdapter.Infrastructure.ErrorHandlers;
using FluentAssertions;
using Moq;
using Newtonsoft.Json;
using NLog;
using NUnit.Framework;
using RestSharp;

namespace BeersApiAdapter.Tests.BeersApi
{
   [TestFixture]
   public class ApiClientTests
   {
      #region Data

      private ApiClient _sut;
      private Logger _logger;
      private Mock<IRestClient> _mockClient;
      private Mock<IMessageBuilder> _mockMessageBuilder;

      #endregion

      [OneTimeSetUp]
      public void BeforeAll()
      {

         _logger = new LogFactory().CreateNullLogger();
      }

      [SetUp]
      public void BeforeEach()
      {

         _mockClient = new Mock<IRestClient>();
         _mockMessageBuilder = new Mock<IMessageBuilder>();
         _mockClient.Setup(x => x.BuildUri(It.IsAny<IRestRequest>())).Returns(new Uri("http://www.test.com"));

         _sut = new ApiClient(_mockClient.Object, _mockMessageBuilder.Object, _logger);
      }

      [Test]
      public void CreateUserAsync_WhenApiClientReturns400BadRequest_ThrowsBeersApiAdapterException()
      {
         //arrange
         var user = new User
         {
            Email = "test@email.com",
            UId = Guid.NewGuid(),
            RoleName = "BeersApiReadOnly",
            FirstName = "username"
         };
         
         var response = new RestResponse { StatusCode = HttpStatusCode.BadRequest, ErrorMessage = "BadRequest" };
         _mockClient.Setup(x => x.ExecutePostAsync(It.IsAny<RestRequest>(), CancellationToken.None))
            .ReturnsAsync(response);
         _mockMessageBuilder.Setup(x => x.CreateUser(user)).ReturnsAsync(new RestRequest { Method = Method.POST, Resource = "resource" });

         //act - assert
         var baae = Assert.ThrowsAsync<BeersApiAdapterException>(async () => await _sut.CreateUserAsync(user));
         baae.Should().NotBe(null);
         baae.Message.Should().Contain(response.ErrorMessage);
      }

      [Test]
      public void CreateUserAsync_WhenApiClientReturns500InternalServerError_ThrowsBeersApiAdapterException()
      {
         //arrange
         var user = new User
         {
            Email = "test@email.com",
            UId = Guid.NewGuid(),
            RoleName = "BeersApiReadOnly",
            FirstName = "username"
         };

         var response = new RestResponse { StatusCode = HttpStatusCode.InternalServerError, ErrorMessage = "InternalServerError" };
         _mockClient.Setup(x => x.ExecutePostAsync(It.IsAny<RestRequest>(), CancellationToken.None))
            .ReturnsAsync(response);
         _mockMessageBuilder.Setup(x => x.CreateUser(user)).ReturnsAsync(new RestRequest { Method = Method.POST, Resource = "resource" });

         //act - assert
         var baae = Assert.ThrowsAsync<BeersApiAdapterException>(async () => await _sut.CreateUserAsync(user));
         baae.Should().NotBe(null);
         baae.Message.Should().Contain(response.ErrorMessage);
      }

      [Test]
      public void CreateUserAsync_WhenResponseThrowsException_ThrowsBeersApiAdapterException()
      {
         //arrange
         var user = new User
         {
            Email = "test@email.com",
            UId = Guid.NewGuid(),
            RoleName = "BeersApiReadOnly",
            FirstName = "username"
         };

         var response = new RestResponse { ErrorException = new Exception("InnerException"), ErrorMessage = "Something wrong happened" };
         _mockClient.Setup(x => x.ExecutePostAsync(It.IsAny<RestRequest>(), CancellationToken.None))
            .ReturnsAsync(response);
         _mockMessageBuilder.Setup(x => x.CreateUser(user)).ReturnsAsync(new RestRequest { Method = Method.POST, Resource = "resource" });

         //act - assert
         var baae = Assert.ThrowsAsync<BeersApiAdapterException>(async () => await _sut.CreateUserAsync(user));
         baae.Should().NotBe(null);
         baae.Message.Should().Contain(response.ErrorMessage);
      }

      [Test]
      public async Task CreateUserAsync_WhenApiReturns200_ReturnsUser()
      {
         //arrange
         var user = new User
         {
            Email = "test@email.com",
            UId = Guid.NewGuid(),
            RoleName = "BeersApiReadOnly",
            FirstName = "username"
         };

         var userResponseModel = new User
         {
            Email = user.Email,
            UId = user.UId,
            RoleName = user.RoleName,
            FirstName = user.FirstName
         };

         var response = new RestResponse { Content = JsonConvert.SerializeObject(userResponseModel), StatusCode = HttpStatusCode.OK };
         _mockClient.Setup(x => x.ExecutePostAsync(It.IsAny<RestRequest>(), CancellationToken.None))
            .ReturnsAsync(response);
         _mockMessageBuilder.Setup(x => x.CreateUser(user)).ReturnsAsync(new RestRequest { Method = Method.POST, Resource = "resource" });

         //act
         var result = await _sut.CreateUserAsync(user);

         //assert
         result.Should().NotBeNull();
         result.Email.Should().Be(user.Email);
         result.UId.Should().Be(user.UId);
         result.RoleName.Should().Be(user.RoleName);
         result.FirstName.Should().Be(user.FirstName);
      }

   }
}
