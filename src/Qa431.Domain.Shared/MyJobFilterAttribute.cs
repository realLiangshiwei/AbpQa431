using System.Linq;
using Hangfire.Common;
using Hangfire.States;

namespace Qa431
{
   public class MyJobFilterAttribute : JobFilterAttribute, IElectStateFilter
   {
       public void OnStateElection(ElectStateContext context)
       {
           if (context.CandidateState is EnqueuedState enqueuedState)
           {
               if (context.BackgroundJob.Job.Args.Any() && context.BackgroundJob.Job.Args[0] is ISpecifiedQueueJob specifiedQueueJob)
               {
                   enqueuedState.Queue = specifiedQueueJob.Queue;
               }

           }
       }
   }

   public interface ISpecifiedQueueJob
   {
       string Queue { get; set; }
   }
}
