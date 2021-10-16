using OA.Domin.DSA;
using OA.Domin.DSA.Indexes;
using OA.WASM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.DSA.DonationRequests
{
    public class DonationRequestEditBase : EditBase<DonationRequest>
    {

        public Dictionary<string, string> DonationTypeItems = new Dictionary<string, string>();

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            DonationTypeItems = await GetIndexData<DonationType>();
        }
    }
}
