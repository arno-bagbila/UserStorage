using System.Threading.Tasks;
using BeersApiAdapter.DTOs;
using BeersApiAdapter.Services;
using NLog;
using NServiceBus;
using UserStorage.BeersApiUpdater.Infrastructure.ErrorHandlers;
using UserStorage.Integration.Messages.Events;

namespace UserStorage.BeersApiUpdater.Handlers
{
   public class UserCreatedHandler : IHandleMessages<UserCreated>
   {

      #region Data

      private readonly IAdapter _adapter;
      private readonly ILogger _logger;

      #endregion

      #region Constructors

      public UserCreatedHandler(IAdapter adapter, ILogger logger)
      {
         _adapter = adapter;
         _logger = logger;
      }

      #endregion


      public async Task Handle(UserCreated message, IMessageHandlerContext context)
      {
         var user = new User
         {
            Email = message.Email,
            UId = message.UId,
            RoleName = message.RoleName,
            FirstName = message.FirstName
         };

         var userCreated = await _adapter.CreateUser(user).ConfigureAwait(false);
         _logger.Info($"Processed message to create User {userCreated.UId} in BeersApi");
      }
   }
}
