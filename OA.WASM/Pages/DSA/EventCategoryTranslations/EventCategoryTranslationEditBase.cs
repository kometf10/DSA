﻿using OA.Domin.DSA;
using OA.WASM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.DSA.EventCategoryTranslations
{
    public class EventCategoryTranslationEditBase : EditBase<EventCategoryTranslation>
    {

        public Dictionary<string, string> EventCategoryItems { get; set; } = new Dictionary<string, string>();

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            EventCategoryItems = await GetIndexData<EventCategory>();

        }


    }
}
