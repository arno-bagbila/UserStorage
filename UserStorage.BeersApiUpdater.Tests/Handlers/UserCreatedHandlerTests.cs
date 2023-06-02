using System;
using System.Threading.Tasks;
using BeersApiAdapter.DTOs;
using BeersApiAdapter.Services;
using Moq;
using NLog;
using NServiceBus.Testing;
using NUnit.Framework;
using UserStorage.BeersApiUpdater.Handlers;
using UserStorage.BeersApiUpdater.Infrastructure.ErrorHandlers;
using UserStorage.Integration.Messages.Events;

namespace UserStorage.BeersApiUpdater.Tests.Handlers
{
   [TestFixture]
   public class UserCreatedHandlerTests
   {
      #region Data

      private UserCreatedHandler _sut;
      private TestableMessageHandlerContext _context;
      private Logger _logger;
      private Mock<IAdapter> _mockAdapter;

      #endregion

      [OneTimeSetUp]
      public void BeforeAll()
      {
         _logger = new LogFactory().CreateNullLogger();
      }

      [SetUp]
      public void BeforeEach()
      {
         _mockAdapter = new Mock<IAdapter>();
         _sut = new UserCreatedHandler(_mockAdapter.Object, _logger);
         _context = new TestableMessageHandlerContext();
      }

      [Test]
      public async Task HandleUserCreated_ValidMessage_CreateUser()
      {
         //arrange
         var msg = new UserCreated
         {
            Email = "email@test.com",
            UId = Guid.NewGuid(),
            RoleName = "BeersApiReadOnly",
            FirstName = "username"
         };

         var userCreated = new User
         {
            Email = msg.Email,
            UId = msg.UId,
            RoleName = msg.RoleName,
            FirstName = msg.FirstName
         };

         _mockAdapter.Setup(x => x.CreateUser(It.IsAny<User>())).ReturnsAsync(userCreated);

         //act
         await _sut.Handle(msg, _context);

         //assert
         _mockAdapter.Verify(x => x.CreateUser(It.IsAny<User>()), Times.Once);
      }
   }
}
