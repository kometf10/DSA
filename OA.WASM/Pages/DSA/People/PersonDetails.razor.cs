using Microsoft.AspNetCore.Components;
using OA.Domin.DSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.DSA.People
{
    public partial class PersonDetails : ComponentBase
    {

        [Parameter]
        public Person Person { get; set; }

    }
}
