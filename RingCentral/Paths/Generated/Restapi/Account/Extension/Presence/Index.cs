using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Presence
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/presence";
        }

        public async Task<RingCentral.GetPresenceInfo> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GetPresenceInfo>(this.Path(), queryParams);
        }

        public async Task<RingCentral.GetPresenceInfo> Get(object queryParams)
        {
            return await rc.Get<RingCentral.GetPresenceInfo>(this.Path(), queryParams);
        }

        public async Task<RingCentral.PresenceInfoResource> Put(RingCentral.PresenceInfoResource presenceInfoResource)
        {
            return await rc.Put<RingCentral.PresenceInfoResource>(this.Path(), presenceInfoResource);
        }

        public async Task<RingCentral.PresenceInfoResource> Put(object presenceInfoResource)
        {
            return await rc.Put<RingCentral.PresenceInfoResource>(this.Path(), presenceInfoResource);
        }
    }

    public class GetQueryParams
    {
        // Whether to return detailed telephony state
        public bool? detailedTelephonyState;

        // Whether to return SIP data
        public bool? sipData;
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Presence.Index Presence()
        {
            return new Restapi.Account.Extension.Presence.Index(this);
        }
    }
}