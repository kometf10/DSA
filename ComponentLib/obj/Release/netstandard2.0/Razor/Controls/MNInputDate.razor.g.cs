#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Controls\MNInputDate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "535ee72c89217bd0d508831549f9f4eddfcd1e22"
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
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
    public partial class MNInputDate : MNInputDateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "md-form");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", 
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Controls\MNInputDate.razor"
                  Type

#line default
#line hidden
            );
            __builder.AddAttribute(4, "id", 
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Controls\MNInputDate.razor"
                             Id

#line default
#line hidden
            );
            __builder.AddAttribute(5, "class", "form-control" + " " + (
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Controls\MNInputDate.razor"
                                                      CssClass

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Controls\MNInputDate.razor"
                                                                        CurrentValue

#line default
#line hidden
            , format: 
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Controls\MNInputDate.razor"
                                                                                                     Format

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValue = __value, CurrentValue, format: Format));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "label");
            __builder.AddAttribute(10, "for", 
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Controls\MNInputDate.razor"
                 Id

#line default
#line hidden
            );
            __builder.AddAttribute(11, "class", "active");
            __builder.AddContent(12, 
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Controls\MNInputDate.razor"
                                      Localizer[Label]

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __Blazor.ComponentLib.Controls.MNInputDate.TypeInference.CreateCustomValidationMessage_0(__builder, 14, 15, 
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\ComponentLib\Controls\MNInputDate.razor"
                                  For

#line default
#line hidden
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ComponentLib.Controls.MNInputDate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomValidationMessage_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0)
        {
        __builder.OpenComponent<global::ComponentLib.CustomValidationMessage<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591