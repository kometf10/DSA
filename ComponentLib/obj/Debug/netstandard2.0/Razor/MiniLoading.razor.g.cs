#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\MiniLoading.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28de133a20ef3add5e9f335132d506bee88008e4"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class MiniLoading : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mini-loading");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "lds-dual-ring");
            __builder.AddAttribute(5, "style", "width:" + (
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\MiniLoading.razor"
                                             size

#line default
#line hidden
            ) + ";" + " height:" + (
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\MiniLoading.razor"
                                                           size

#line default
#line hidden
            ) + ";");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 8 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\MiniLoading.razor"
      
    [Parameter]
    public string size { get; set; } = "40px";

#line default
#line hidden
    }
}
#pragma warning restore 1591
