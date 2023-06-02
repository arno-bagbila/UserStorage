using System;
using System.Threading.Tasks;
using BeersApiAdapter.DTOs;

namespace BeersApiAdapter.BeersApi
{
   public interface IApiClient
   {
      Task<User> CreateUserAsync(User user);
   }
}
