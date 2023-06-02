using System;

namespace BeersApiAdapter.DTOs
{
   public class User
   {
      public Guid UId { get; set; }

      public string Email { get; set; }

      public string RoleName { get; set; }

      public string  FirstName { get; set; }
   }
}
