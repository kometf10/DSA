using Microsoft.AspNetCore.Components;
using OA.Domin.DSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.DSA.Projects
{
    public partial class ProjectForm : ComponentBase
    {

        [Parameter]
        public bool IsEdit { get; set; }

        [Parameter]
        public Project Project { get; set; } = new Project();


        public string Active { get; set; } = "";


        protected override void OnInitialized()
        {
            Active = (IsEdit) ? "active" : "";

            //ActivityItems = StaticIndexes.Genders;
        }

    }
}
