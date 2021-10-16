﻿using Microsoft.AspNetCore.Components;
using OA.Domin;
using OA.Domin.DSA.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.DSA.Indexes.DonationTypes
{
    public partial class DonationTypeForm : ComponentBase
    {

        [Parameter]
        public bool IsEdit { get; set; }

        [Parameter]
        public DonationType DonationType { get; set; }

        public string Active { get; set; } = "";

        protected override void OnInitialized()
        {
            Active = (IsEdit) ? "active" : "";

        }
    }
}
