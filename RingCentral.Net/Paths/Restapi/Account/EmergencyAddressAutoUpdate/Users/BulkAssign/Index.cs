using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Users.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.EmergencyAddressAutoUpdate.Users.Index parent;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Users.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        /// Enables or disables Automatic Location Updates feature for multiple account users.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/emergency-address-auto-update/users/bulk-assign
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Post(
            RingCentral.BulkAssignAutomaticLocationUpdatesUsers bulkAssignAutomaticLocationUpdatesUsers,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), bulkAssignAutomaticLocationUpdatesUsers, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Users
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.Users.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.Users.BulkAssign.Index(this);
        }
    }
}