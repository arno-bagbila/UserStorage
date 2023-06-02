using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeersApiAdapter.Infrastructure.ErrorHandlers
{
   public class BeersApiAdapterException :Exception
   {
      public BeersApiAdapterException(string message) : base(message) { }

      public BeersApiAdapterException(string message, Exception innerException)
         : base(message, innerException) { }
   }
}
