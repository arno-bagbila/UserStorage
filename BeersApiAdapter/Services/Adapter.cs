using System;
using System.Threading.Tasks;
using BeersApiAdapter.BeersApi;
using BeersApiAdapter.DTOs;

namespace BeersApiAdapter.Services
{
   public class Adapter : IAdapter
   {

      #region Data

      private readonly IApiClient _apiClient;

      #endregion

      #region Constructors

      public Adapter(IApiClient apiClient)
      {
         _apiClient = apiClient;
      }

      #endregion

     /// <summary>
     /// Create user in BeersApi
     /// </summary>
     /// <param name="user"></param>
     /// <returns>User crested in BeersApi</returns>
     /// <exception cref="BeersApiException"></exception>
      public Task<User> CreateUser(User user) => _apiClient.CreateUserAsync(user);
   }
}
