using System.Threading.Tasks;
using NLog;
using NServiceBus;
using UserStorage.Integration.Messages.Commands;
using UserStorage.Integration.Messages.Events;

namespace UserStorage.BeersApiUpdater.Handlers
{
   public class CreateUserHandler : IHandleMessages<CreateUser>
   {

      #region Data

      private readonly ILogger _logger;

      #endregion

      #region Constructors

      public CreateUserHandler(ILogger logger)
      {
         _logger = logger;
      }

      #endregion

      public async Task Handle(CreateUser message, IMessageHandlerContext context)
      {
         var userCreated = new UserCreated
         {
            Email = message.Email,
            UId = message.UId,
            RoleName = message.RoleName,
            FirstName = message.FirstName
         };

         await context.Publish(userCreated).ConfigureAwait(false);
         _logger.Info($"Processed message to publish UsrCreated event for user with unique id {message.UId}.");
      }
   }
}
