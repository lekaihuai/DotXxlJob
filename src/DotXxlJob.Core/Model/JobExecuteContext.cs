using System.Runtime.Serialization;
using System.Threading;
using System.Xml.Linq;

namespace DotXxlJob.Core.Model
{
    public class JobExecuteContext
    {
        public JobExecuteContext(IJobLogger jobLogger, string jobParameter, int broadcastIndex, int broadcastTotal, CancellationToken cancellationToken)
        {
            this.JobLogger = jobLogger;
            this.JobParameter = jobParameter;
            this.BroadcastIndex = broadcastIndex;
            this.BroadcastTotal = broadcastTotal;
            this.cancellationToken = cancellationToken;
        }
        public string JobParameter { get; }

        public int BroadcastIndex { get; set; }
        public int BroadcastTotal { get; set; }
        public IJobLogger JobLogger { get; }
        public CancellationToken cancellationToken { get; }
    }
}