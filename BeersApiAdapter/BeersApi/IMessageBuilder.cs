using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeersApiAdapter.DTOs;
using RestSharp;

namespace BeersApiAdapter.BeersApi
{
   public interface IMessageBuilder
   {
      Task<RestRequest> CreateUser(User user);

      Task<RestRequest> GetUser(string email);
   }
}
