using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.Favorite
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
            return $"{parent.Path()}/favorite";
        }

        /// <summary>
        /// Returns the list of favorite contacts of the current extension. Favorite contacts include both company contacts (extensions) and personal contacts (address book records).
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/favorite
        /// Rate Limit Group: Light
        /// App Permission: ReadContacts
        /// User Permission: ReadPersonalContacts
        /// </summary>
        public async Task<RingCentral.FavoriteContactList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.FavoriteContactList>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the list of favorite contacts of the current extension. Favorite contacts include both company contacts (extensions) and personal contacts (address book records).**Please note**: currently personal address book size is limited to 10 000 contacts.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/favorite
        /// Rate Limit Group: Medium
        /// App Permission: Contacts
        /// User Permission: EditPersonalContacts
        /// </summary>
        public async Task<RingCentral.FavoriteContactList> Put(RingCentral.FavoriteCollection favoriteCollection,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.FavoriteContactList>(this.Path(), favoriteCollection, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Favorite.Index Favorite()
        {
            return new Restapi.Account.Extension.Favorite.Index(this);
        }
    }
}