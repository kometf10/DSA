using Microsoft.AspNetCore.Components;
using OA.Domin.DSA.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.DSA.Indexes.Activities
{
    public partial class ActivityForm : ComponentBase
    {


        [Parameter]
        public bool IsEdit { get; set; }

        [Parameter]
        public Activity Activity { get; set; } = new Activity();

        public string Active { get; set; } = "";

        protected override void OnInitialized()
        {
            Active = (IsEdit) ? "active" : "";

        }

    }
}
