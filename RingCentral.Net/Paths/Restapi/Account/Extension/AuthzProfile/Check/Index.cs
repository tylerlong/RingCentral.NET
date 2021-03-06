using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.AuthzProfile.Check
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.AuthzProfile.Index parent;

        public Index(Restapi.Account.Extension.AuthzProfile.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/check";
        }

        /// <summary>
        /// Checks if a certain user permission is activated for a particular extension.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/authz-profile/check
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.AuthProfileCheckResource> Get(
            RingCentral.CheckUserPermissionParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.AuthProfileCheckResource>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.AuthzProfile
{
    public partial class Index
    {
        public Restapi.Account.Extension.AuthzProfile.Check.Index Check()
        {
            return new Restapi.Account.Extension.AuthzProfile.Check.Index(this);
        }
    }
}