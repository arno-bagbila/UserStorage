using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeersApiAdapter.DTOs;
using RestSharp;

namespace BeersApiAdapter.BeersApi
{
   public class MessageBuilder : IMessageBuilder
   {

      private struct Endpoints
      {

         public const string USERS = "users";
      }
      
      public async Task<RestRequest> CreateUser(User user)
      {
         var request = await PrepareRequest(Endpoints.USERS, Method.POST);
         request.AddJsonBody(user);
         return request;
      }

      public async Task<RestRequest> GetUser(string email) => await PrepareRequest($"{Endpoints.USERS}/{email}", Method.GET);

      #region Private Methods

      private async Task<RestRequest> PrepareRequest(string requestUri, Method method)
      {

         //var token = await _tokenProvider.GetAuthorizationToken();

         var request = new RestRequest(requestUri, method);
         //
         //request.AddHeader("Authorization", $"Bearer {token}");
         request.RequestFormat = DataFormat.Json;

         return request;
      }

      #endregion
   }
}
