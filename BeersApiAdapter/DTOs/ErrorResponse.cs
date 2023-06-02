using System.Collections.Generic;

namespace BeersApiAdapter.DTOs
{
   public class ErrorResponse
   {
      public int StatusCode { get; set; }

      public string Message { get; set; }

      public string Details { get; set; }

      public List<string> InvalidProperties { get; set; }
   }
}
