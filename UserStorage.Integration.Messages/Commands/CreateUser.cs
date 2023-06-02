using System;
using NServiceBus;

namespace UserStorage.Integration.Messages.Commands
{
   public class CreateUser : ICommand
   {
      /// <summary>
      /// User unique identifier
      /// </summary>
      public Guid UId { get; set; }

      /// <summary>
      /// User Email
      /// </summary>
      public string Email { get; set; }

      /// <summary>
      /// User Role
      /// </summary>
      public string RoleName { get; set; }

      /// <summary>
      /// User username
      /// </summary>
      public string FirstName { get; set; }
   }
}
