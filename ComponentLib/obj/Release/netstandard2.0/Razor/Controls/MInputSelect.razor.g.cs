#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\MInputSelect.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eade63b1ea9a5620dce65532bee6ec1d4c0d33e"
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
    public partial class MInputSelect<T> : MInputSelectBase<T>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "select");
            __builder.AddAttribute(1, "class", "form-control" + " " + (
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\MInputSelect.razor"
                             Cls

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "id", 
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\MInputSelect.razor"
                                       Id

#line default
#line hidden
            );
            __builder.AddAttribute(3, "style", "width:100%");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\MInputSelect.razor"
                                                                     CurrentValue

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValue = __value, CurrentValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\MInputSelect.razor"
     foreach (var item in Items)
    {

#line default
#line hidden
            __builder.AddContent(10, "        ");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", 
#line 8 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\MInputSelect.razor"
                        item.Key

#line default
#line hidden
            );
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.AddContent(14, 
#line 9 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\MInputSelect.razor"
             item.Value

#line default
#line hidden
            );
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#line 11 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\MInputSelect.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n\r\n");
            __Blazor.ComponentLib.Controls.MInputSelect.TypeInference.CreateCustomValidationMessage_0(__builder, 18, 19, 
#line 15 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\Controls\MInputSelect.razor"
                              For

#line default
#line hidden
            );
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ComponentLib.Controls.MInputSelect
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
