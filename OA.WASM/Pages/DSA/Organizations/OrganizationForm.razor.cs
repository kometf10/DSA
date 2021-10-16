using Microsoft.AspNetCore.Components;
using OA.Domin.DSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.DSA.Organizations
{
    public partial class OrganizationForm : ComponentBase
    {

        [Parameter]
        public bool IsEdit { get; set; }

        [Parameter]
        public Organization Organization { get; set; } = new Organization();


        public string Active { get; set; } = "";


        protected override void OnInitialized()
        {
            Active = (IsEdit) ? "active" : "";

            //ActivityItems = StaticIndexes.Genders;
        }

    }
}
