// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ComponentLib
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#line 3 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
    public partial class GridRowOptions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 31 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridRowOptions.razor"
      

    [Parameter]
    public EventCallback EditEvent { get; set; }

    [Parameter]
    public EventCallback DeleteEvent { get; set; }

    [Parameter]
    public EventCallback DetailsEvent { get; set; }


    public string open { get; set; } = "";

    public void ToggleOptions()
    {
        if (string.IsNullOrEmpty(open))
            open = "options-open";
        else
            open = "";
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
