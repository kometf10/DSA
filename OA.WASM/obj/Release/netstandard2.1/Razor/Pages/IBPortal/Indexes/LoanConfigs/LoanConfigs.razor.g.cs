#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d58e9a8b11d2cb851208087518710d79be413ca7"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.IBPortal.Indexes.LoanConfigs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor"
           [Authorize(Policy = "loan-configs")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LoanConfigs")]
    public partial class LoanConfigs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, 
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor"
     Localizer["Loan Configurations"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor"
                 LoanConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row mt-5");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "md-form col-sm-5");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "type", "number");
                __builder2.AddAttribute(13, "autocomplete", "off");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "id", "l1");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor"
                                                                                              LoanConfig.Limit1

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LoanConfig.Limit1 = __value, LoanConfig.Limit1, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenElement(19, "label");
                __builder2.AddAttribute(20, "for", "l1");
                __builder2.AddAttribute(21, "class", "active");
                __builder2.AddContent(22, 
#nullable restore
#line 14 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor"
                                             Localizer["Limit 1"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        <div class></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group row");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "md-form col-sm-5");
                __builder2.OpenElement(29, "input");
                __builder2.AddAttribute(30, "type", "number");
                __builder2.AddAttribute(31, "autocomplete", "off");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "id", "l2");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor"
                                                                                              LoanConfig.Limit2

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LoanConfig.Limit2 = __value, LoanConfig.Limit2, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "label");
                __builder2.AddAttribute(38, "for", "l2");
                __builder2.AddAttribute(39, "class", "active");
                __builder2.AddContent(40, 
#nullable restore
#line 24 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor"
                                              Localizer["Limit 2"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group row mt-5 pt-5");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-sm-5");
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "type", "button");
                __builder2.AddAttribute(48, "class", "btn btn-comp btn-block btn-sm");
                __builder2.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor"
                                                                                  SetConfigs

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(50, 
#nullable restore
#line 30 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor"
                                                                                                Localizer["Save"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-sm-1 pt-1 text-center");
#nullable restore
#line 33 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor"
             if (SaveBusy)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.MiniLoading>(54);
                __builder2.AddAttribute(55, "size", "25px");
                __builder2.CloseComponent();
#nullable restore
#line 34 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\Indexes\LoanConfigs\LoanConfigs.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591