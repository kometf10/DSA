using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OA.Domin.DSA.Indexes;

namespace OA.WASM.Pages.DSA.Indexes.Governorates
{
    public partial class GovernorateForm : ComponentBase
    {

        [Parameter]
        public bool IsEdit { get; set; }

        [Parameter]
        public Governorate Governorate { get; set; } = new Governorate();

        public string Active { get; set; } = "";

        protected override void OnInitialized()
        {
            Active = (IsEdit) ? "active" : "";

        }

    }
}
