﻿using OA.Domin.DSA;
using OA.WASM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;

namespace OA.WASM.Pages.DSA.Events
{
    public partial class EventDetailsBase : DetailsBase<Event>
    {

        [Inject]
        public IConfiguration Configuration { get; set; }

        public string PathPrefix { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            PathPrefix = Configuration.GetSection("BaseUri").Value;

        }

    }
}
