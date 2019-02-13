using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Grant
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
            return $"{parent.Path()}/grant";
        }

        public async Task<RingCentral.GetExtensionGrantListResponse> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GetExtensionGrantListResponse>(this.Path(), queryParams);
        }

        public async Task<RingCentral.GetExtensionGrantListResponse> Get(object queryParams)
        {
            return await rc.Get<RingCentral.GetExtensionGrantListResponse>(this.Path(), queryParams);
        }
    }

    public class GetQueryParams
    {
        public string page;

        public string perPage;
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Grant.Index Grant()
        {
            return new Restapi.Account.Extension.Grant.Index(this);
        }
    }
}