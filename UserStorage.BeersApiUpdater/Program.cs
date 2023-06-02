using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NServiceBus;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using UserStorage.BeersApiUpdater.Infrastructure.IoC;

namespace UserStorage.BeersApiUpdater
{
   class Program
   {
      public static async Task Main(string[] args)
      {

         await CreateHostBuilder()
            .Build()
            .RunAsync();

         //Console.Title = "BeersApiUpdater";

         //var endpointConfiguration = new EndpointConfiguration("BeersApiUpdater");

         //var transport = endpointConfiguration.UseTransport<LearningTransport>();

         //var endpointInstance = await Endpoint.Start(endpointConfiguration)
         //   .ConfigureAwait(false);

         //Console.WriteLine("Press Enter to exit.");
         //Console.ReadLine();

         //await endpointInstance.Stop()
         //   .ConfigureAwait(false);
      }

      public static IHostBuilder CreateHostBuilder()
      {
         var builder = Host
            .CreateDefaultBuilder();

         #region Dependency Injection

         builder
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureServices((ctx, services) =>
            {
               services.AddSingleton(ctx.Configuration);
            })
            .ConfigureContainer<ContainerBuilder>((ctx, containerBuilder) =>
            {
               // IConfiguration available here (ctx.Configuration) if required
               containerBuilder
                  .RegisterAssemblyModules(Assembly.GetExecutingAssembly());

               //install NLogMiddleware for all components
               containerBuilder.ComponentRegistryBuilder.Registered += (sender, args) =>
               {
                  args.ComponentRegistration.PipelineBuilding += (s, pipeline) =>
                  {
                     pipeline.Use(new NLogMiddleware());
                  };
               };
            });

         #endregion


         #region NServiceBus

         builder.UseNServiceBus(ctx =>
         {
            var endpointConfiguration = new EndpointConfiguration("BeersApiUpdater");
            endpointConfiguration.UseTransport<LearningTransport>();

            return endpointConfiguration;
         });

         #endregion

         return builder;
      }
   }
}
