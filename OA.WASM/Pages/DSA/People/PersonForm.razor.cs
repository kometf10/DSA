using Microsoft.AspNetCore.Components;
using OA.Domin;
using OA.Domin.DSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.DSA.People
{
    public partial class PersonForm : ComponentBase
    {

        [Parameter]
        public bool IsEdit { get; set; }

        [Parameter]
        public Person Person { get; set; } = new Person();

        public string Active { get; set; } = "";

        public Dictionary<string, string> GenderItems = new Dictionary<string, string>();

        protected override void OnInitialized()
        {
            Active = (IsEdit) ? "active" : "";

            GenderItems = StaticIndexes.Genders;

        }

    }
}
