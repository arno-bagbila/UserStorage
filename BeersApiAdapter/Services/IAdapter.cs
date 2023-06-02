using System;
using System.Threading.Tasks;
using BeersApiAdapter.DTOs;

namespace BeersApiAdapter.Services
{
   public interface IAdapter
   {
      Task<User> CreateUser(User user);
   }
}
