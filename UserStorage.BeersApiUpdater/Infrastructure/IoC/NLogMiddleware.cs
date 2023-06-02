using System;
using System.Linq;
using Autofac.Core;
using Autofac.Core.Resolving.Pipeline;

namespace UserStorage.BeersApiUpdater.Infrastructure.IoC
{

   /// <summary>
   /// Custom middleware to resolve <see cref="NLog.ILogger"/>
   /// </summary>
   internal class NLogMiddleware : IResolveMiddleware
   {
      public void Execute(ResolveRequestContext context, Action<ResolveRequestContext> next)
      {
         // Resolve NLog.ILogger
         // TODO optimize?
         context.ChangeParameters(context.Parameters.Union(new[] {
            new ResolvedParameter(
               (p, i) => p.ParameterType == typeof(NLog.ILogger),
               (p, i) => NLog.LogManager.GetLogger(p.Member.DeclaringType.FullName)
            )
         }));

         // process next step
         next(context);
      }

      public PipelinePhase Phase => PipelinePhase.ParameterSelection;
   }
}
