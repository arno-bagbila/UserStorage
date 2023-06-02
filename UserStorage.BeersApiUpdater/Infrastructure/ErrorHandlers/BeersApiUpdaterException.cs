using System;

namespace UserStorage.BeersApiUpdater.Infrastructure.ErrorHandlers
{
   public class BeersApiUpdaterException : Exception
   {
      public BeersApiUpdaterException(string message) : base(message) { }

      public BeersApiUpdaterException(string message, Exception innerException) : base(message, innerException) { }
   }
}
