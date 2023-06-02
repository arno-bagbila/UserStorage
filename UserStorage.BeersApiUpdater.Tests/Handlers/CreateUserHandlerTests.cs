using System;
using System.Threading.Tasks;
using FluentAssertions;
using NLog;
using NServiceBus.Testing;
using NUnit.Framework;
using UserStorage.BeersApiUpdater.Handlers;
using UserStorage.Integration.Messages.Commands;
using UserStorage.Integration.Messages.Events;

namespace UserStorage.BeersApiUpdater.Tests.Handlers
{
   [TestFixture]
   public class CreateUserHandlerTests
   {
      #region Data

      private CreateUserHandler _sut;
      private TestableMessageHandlerContext _context;
      private Logger _logger;

      #endregion

      [OneTimeSetUp]
      public void BeforeAll()
      {
         _logger = new LogFactory().CreateNullLogger();
      }

      [SetUp]
      public void BeforeEach()
      {
         _sut = new CreateUserHandler(_logger);
         _context = new TestableMessageHandlerContext();
      }

      [Test]
      public async Task HandleCreateUser_ValidMessage_PublishUserCreatedEvent()
      {
         //arrange
         var msg = new CreateUser
         {
            Email = "email@test.com",
            UId = Guid.NewGuid(),
            RoleName = "BeersApiReadOnly",
            FirstName = "username"
         };
         
         //act
         await _sut.Handle(msg, _context);
         
         //assert
         var publishedMessages = _context.PublishedMessages;
         Assert.AreEqual(1, publishedMessages.Length);
         Assert.IsInstanceOf<UserCreated>(publishedMessages[0].Message);
         var userCreatedEvent = publishedMessages[0].Message as UserCreated;
         userCreatedEvent.Email.Should().Be(msg.Email);
         userCreatedEvent.UId.Should().Be(msg.UId);
         userCreatedEvent.RoleName.Should().Be(msg.RoleName);
         userCreatedEvent.FirstName.Should().Be(msg.FirstName);
      }
   }
}
