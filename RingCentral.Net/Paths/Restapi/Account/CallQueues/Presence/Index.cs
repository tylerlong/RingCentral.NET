using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CallQueues.Presence
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.CallQueues.Index parent;

        public Index(Restapi.Account.CallQueues.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/presence";
        }

        /// <summary>
        /// Returns presence status of the call queue members.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/presence
        /// Rate Limit Group: Light
        /// App Permission: ReadPresence
        /// </summary>
        public async Task<RingCentral.CallQueuePresence> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CallQueuePresence>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates presence status of the call queue members in the specified queue.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/call-queues/{groupId}/presence
        /// Rate Limit Group: Medium
        /// App Permission: EditPresence
        /// </summary>
        public async Task<RingCentral.CallQueuePresence> Put(
            RingCentral.CallQueueUpdatePresence callQueueUpdatePresence, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.CallQueuePresence>(this.Path(), callQueueUpdatePresence, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.CallQueues
{
    public partial class Index
    {
        public Restapi.Account.CallQueues.Presence.Index Presence()
        {
            return new Restapi.Account.CallQueues.Presence.Index(this);
        }
    }
}