using Microsoft.AspNetCore.Components;
using OA.Domin.DSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.DSA.Vacancies
{
    public partial class VacancyForm : ComponentBase
    {
        [Parameter]
        public bool IsEdit { get; set; }

        [Parameter]
        public Vacancy Vacancy { get; set; } = new Vacancy();


        public string Active { get; set; } = "";


        protected override void OnInitialized()
        {
            Active = (IsEdit) ? "active" : "";

            //ActivityItems = StaticIndexes.Genders;
        }
    }
}
