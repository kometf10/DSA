#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\CheckBoxList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0a73d917cc6d42b07a1e62772d6c5237fdc4225"
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
    public partial class CheckBoxList<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "md-form col-md-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "autocomplete", "off");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "id", "filter");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 5 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\CheckBoxList.razor"
                            FilterValue

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FilterValue = __value, FilterValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "label");
            __builder.AddAttribute(14, "for", "filter");
            __builder.AddAttribute(15, "class", "active");
            __builder.AddContent(16, " ");
            __builder.AddContent(17, 
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\CheckBoxList.razor"
                                             Localizer["Filter"]

#line default
#line hidden
            );
            __builder.AddContent(18, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "   \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "checkbox-list");
            __builder.AddMarkupContent(24, " \r\n");
#line 11 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\CheckBoxList.razor"
     foreach(var item in Selected)
    {
        var Name = item.Key.GetType().GetProperty(NameField).GetValue(item.Key);
        var Value = item.Key.GetType().GetProperty(ValueField).GetValue(item.Key);


#line default
#line hidden
            __builder.AddContent(25, "    ");
            __builder.OpenElement(26, "label");
            __builder.AddAttribute(27, "class", "check-container");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "name");
            __builder.AddMarkupContent(31, "\r\n");
#line 18 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\CheckBoxList.razor"
             if (!string.IsNullOrEmpty(FilterValue) && ((string)Name).ToLower().Contains(FilterValue.ToLower()))
            {

#line default
#line hidden
            __builder.AddContent(32, "                ");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "style", "color:forestgreen; font-weight:bold");
            __builder.AddContent(35, " ");
            __builder.AddContent(36, 
#line 20 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\CheckBoxList.razor"
                                                                    Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#line 21 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\CheckBoxList.razor"
            }
            else
            {
                

#line default
#line hidden
            __builder.AddContent(38, 
#line 24 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\CheckBoxList.razor"
                 Name

#line default
#line hidden
            );
#line 24 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\CheckBoxList.razor"
                     
            }

#line default
#line hidden
            __builder.AddContent(39, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "checkbox");
            __builder.AddAttribute(43, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 27 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\CheckBoxList.razor"
                                      Selected[item.Key]

#line default
#line hidden
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Selected[item.Key] = __value, Selected[item.Key]));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        <span class=\"checkmark\"></span>\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#line 31 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\CheckBoxList.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
