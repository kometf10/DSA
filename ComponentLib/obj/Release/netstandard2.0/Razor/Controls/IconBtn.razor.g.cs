#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\IconBtn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c5190e1145b1bb70d2d08c7bfab4d54aac632df"
// <auto-generated/>
#pragma warning disable 1591
namespace ComponentLib.Controls
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
    public partial class IconBtn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "type", "button");
            __builder.AddAttribute(2, "class", "comp-icon-btn" + " " + (
#line 2 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\IconBtn.razor"
                                            ClassList

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 2 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\IconBtn.razor"
                                                                 BtnClick

#line default
#line hidden
            ));
            __builder.AddMultipleAttributes(4, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 2 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\IconBtn.razor"
                                                                                        Attrs

#line default
#line hidden
            ));
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "i");
            __builder.AddAttribute(7, "class", 
#line 3 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\IconBtn.razor"
               IconClassList

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\IconBtn.razor"
      

    [Parameter]
    public string ClassList { get; set; }

    [Parameter]
    public string IconClassList { get; set; }

    [Parameter]
    public EventCallback ClickCallBack { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> Attrs { get; set; }

    public async Task BtnClick()
    {
        if(ClickCallBack.HasDelegate)
            await ClickCallBack.InvokeAsync(this);
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
