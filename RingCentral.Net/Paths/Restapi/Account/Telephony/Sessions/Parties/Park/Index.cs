using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties.Park
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Telephony.Sessions.Parties.Index parent;

        public Index(Restapi.Account.Telephony.Sessions.Parties.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/park";
        }

        /// <summary>
        /// Parks a call to a virtual location from where it can further be retrieved by any user from any phone of the system. The call session and call party identifiers should be specified in path. Currently the users can park only their own incoming calls. Up to 50 calls can be parked simultaneously. Park location starts with asterisk (*) and ranges 801-899.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/park
        /// Rate Limit Group: Light
        /// App Permission: CallControl
        /// </summary>
        public async Task<RingCentral.CallParty> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CallParty>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Telephony.Sessions.Parties
{
    public partial class Index
    {
        public Restapi.Account.Telephony.Sessions.Parties.Park.Index Park()
        {
            return new Restapi.Account.Telephony.Sessions.Parties.Park.Index(this);
        }
    }
}