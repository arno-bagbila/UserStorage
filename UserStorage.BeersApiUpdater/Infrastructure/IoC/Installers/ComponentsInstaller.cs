using Autofac;
using BeersApiAdapter.BeersApi;
using BeersApiAdapter.Services;
using Microsoft.Extensions.Configuration;
using NLog;
using RestSharp;

namespace UserStorage.BeersApiUpdater.Infrastructure.IoC.Installers
{
   public class ComponentsInstaller : Module
   {
      protected override void Load(ContainerBuilder builder)
      {

         builder
            .RegisterType<Adapter>()
            .AsImplementedInterfaces();
         
         builder
            .RegisterType<ApiClient>()
            .AsImplementedInterfaces();

         builder
            .RegisterType<MessageBuilder>()
            .AsImplementedInterfaces();

         builder
            .Register(ctx =>
            {
               var config = ctx.Resolve<IConfiguration>();
               var serviceUrl = "https://localhost:44346";

               return new RestClient(serviceUrl);
            })
            .AsImplementedInterfaces();
      }
   }
}
