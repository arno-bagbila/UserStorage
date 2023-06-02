using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BeersApiAdapter.DTOs;
using BeersApiAdapter.Infrastructure.ErrorHandlers;
using Newtonsoft.Json;
using NLog;
using RestSharp;

namespace BeersApiAdapter.BeersApi
{
   public class ApiClient : IApiClient
   {
      #region Data

      private readonly IRestClient _restClient;
      private readonly ILogger _logger;
      private readonly IMessageBuilder _messageBuilder;

      #endregion

      #region Constructors

      public ApiClient(IRestClient restClient, IMessageBuilder messageBuilder, ILogger logger)
      {
         _restClient = restClient;
         _logger = logger;
         _messageBuilder = messageBuilder;
      }

      #endregion
      
      /// <summary>
      /// Create user in BeersApi
      /// </summary>
      /// <param name="user">user to create</param>
      /// <returns><see cref="User"/> created</returns>
      /// <exception cref="BeersApiAdapterException">When something wrong happened</exception>
      public async Task<User> CreateUserAsync(User user)
      {
         var request = await _messageBuilder.CreateUser(user).ConfigureAwait(false);
         var requestUri = _restClient.BuildUri(request);
         _logger.Info($"Sending POST to create user {user.UId} in BeersApi - [{requestUri}]");
         var response = await _restClient.ExecutePostAsync(request).ConfigureAwait(false);

         CheckResponse(response, request);

         return JsonConvert.DeserializeObject<User>(response.Content);
      }


      #region Private Methods

      /// <summary>
      /// Handling Api call from BeersApi
      /// </summary>
      /// <param name="response">Response from api call fo BeersApi</param>
      /// <param name="request">Request sent to BeersApi</param>
      private void CheckResponse(IRestResponse response, IRestRequest request)
      {
         if (response.StatusCode == HttpStatusCode.InternalServerError ||
             response.StatusCode == HttpStatusCode.BadRequest)
         {
            var errorMessage = "";

            if (!string.IsNullOrWhiteSpace(response.Content))
            {
               var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
               errorMessage = errorResponse.Message;
               _logger.Error(errorResponse.Message);
            }
            
            throw new BeersApiAdapterException(
               $"{request.Method} {request.Resource} failed ({response.StatusCode}): {errorMessage}");
         }

         if (response.ErrorException != null)
         {
            _logger.Error($"Error executing {request.Method} request to '{request.Resource}': {response.ErrorException.Message}");
            var baae = new BeersApiAdapterException($"{request.Method} {request.Resource} failed : {response.ErrorMessage}", response.ErrorException);
            throw baae;
         }
      }

      #endregion
   }
}
