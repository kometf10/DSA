using Microsoft.AspNetCore.Components;
using OA.Domin.DSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.DSA.CorporateDonators
{
    public partial class CorporateDonatorForm : ComponentBase
    {

        [Parameter]
        public bool IsEdit { get; set; }

        [Parameter]
        public CorporateDonator CorporateDonator { get; set; } = new CorporateDonator();

        [Parameter]
        public Dictionary<string, string> ActivityItems { get; set; } = new Dictionary<string, string>();

        public string Active { get; set; } = "";

       

        protected override void OnInitialized()
        {
            Active = (IsEdit) ? "active" : "";

            //ActivityItems = StaticIndexes.Genders;

        }

    }
}
