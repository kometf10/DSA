#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8adabccef9563bc8d0d803b042a1b3f946999b56"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Weather
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
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/wather")]
    public partial class WatherForcastList : WatherForcastListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
 if (ListData == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Loading>(0);
            __builder.CloseComponent();
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "position:relative");
            __builder.AddAttribute(3, "class", "mb-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page-title filter-title");
            __builder.AddContent(6, 
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                               Localizer["Weather Forcast"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenComponent<ComponentLib.GridFilter<OA.Domin.WeatherForecast>>(8);
            __builder.AddAttribute(9, "SearchSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<OA.Domin.DataFilter.FilterParams>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<OA.Domin.DataFilter.FilterParams>>(this, 
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                               SearchEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "GetIndexData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                                                          GetIndexDataEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(11, (__value) => {
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                                                                                   GridFilterRef = (ComponentLib.GridFilter<OA.Domin.WeatherForecast>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "filter-link");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(15);
            __builder.AddAttribute(16, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(17, "IconClassList", "fas fa-plus");
            __builder.AddAttribute(18, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                                                                                      () => NavigationManager.NavigateTo("/weather/create") 

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "export-links");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(22);
            __builder.AddAttribute(23, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(24, "IconClassList", "far fa-file-excel i-lg");
            __builder.AddAttribute(25, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 22 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                                                                                                 () => Export("Exel", nameof(OA.Domin.WeatherForecast))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(27);
            __builder.AddAttribute(28, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(29, "IconClassList", "far fa-file-pdf i-lg");
            __builder.AddAttribute(30, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 23 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                                                                                               () => Export("Pdf", nameof(OA.Domin.WeatherForecast))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 24 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
             if (ExportBusy)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.MiniLoading>(31);
            __builder.AddAttribute(32, "size", "25px");
            __builder.CloseComponent();
#nullable restore
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"

    if (GetBusy)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Loading>(33);
            __builder.CloseComponent();
#nullable restore
#line 33 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __Blazor.OA.WASM.Pages.Weather.WatherForcastList.TypeInference.CreateGrid_0(__builder, 34, 35, 
#nullable restore
#line 36 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                     ListData

#line default
#line hidden
#nullable disable
            , 36, (__builder2) => {
                __builder2.OpenElement(37, "th");
                __builder2.AddContent(38, 
#nullable restore
#line 38 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                      Localizer["Date"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.OpenElement(40, "th");
                __builder2.AddContent(41, 
#nullable restore
#line 39 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                      Localizer["Temperature C"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.OpenElement(43, "th");
                __builder2.AddContent(44, 
#nullable restore
#line 40 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                      Localizer["Temperature F"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenElement(46, "th");
                __builder2.AddContent(47, 
#nullable restore
#line 41 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                      Localizer["Summary"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.OpenElement(49, "th");
                __builder2.AddContent(50, 
#nullable restore
#line 42 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                      Localizer["City"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "th");
                __builder2.AddContent(53, 
#nullable restore
#line 43 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                      Localizer["Options"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            , 54, (context) => (__builder2) => {
                __builder2.OpenElement(55, "td");
                __builder2.OpenElement(56, "span");
                __builder2.AddContent(57, 
#nullable restore
#line 46 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                             Localizer["Date"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(58, " ");
                __builder2.AddContent(59, 
#nullable restore
#line 46 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                        context.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.OpenElement(61, "td");
                __builder2.OpenElement(62, "span");
                __builder2.AddContent(63, 
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                             Localizer["Temperature C"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(64, " ");
                __builder2.AddContent(65, 
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                                 context.TemperatureC

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.OpenElement(67, "td");
                __builder2.OpenElement(68, "span");
                __builder2.AddContent(69, 
#nullable restore
#line 48 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                             Localizer["Temperature F"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(70, " ");
                __builder2.AddContent(71, 
#nullable restore
#line 48 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                                 context.TemperatureF

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                ");
                __builder2.OpenElement(73, "td");
                __builder2.OpenElement(74, "span");
                __builder2.AddContent(75, 
#nullable restore
#line 49 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                             Localizer["Summary"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(76, " ");
                __builder2.AddContent(77, 
#nullable restore
#line 49 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                           context.Summary

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.OpenElement(79, "td");
                __builder2.OpenElement(80, "span");
                __builder2.AddContent(81, 
#nullable restore
#line 51 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                            Localizer["City"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 52 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                     if (context.City != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(82, 
#nullable restore
#line 53 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                      context.City.Name

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 53 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                       }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.OpenElement(84, "td");
                __builder2.OpenComponent<ComponentLib.GridRowOptions>(85);
                __builder2.AddAttribute(86, "EditEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 56 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                 () => NavigationManager.NavigateTo("/weather/edit/" + context.Id) 

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(87, "DeleteEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 57 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                   () => DeleteItem(context.Id) 

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(88, "DetailsEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 58 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                    () => NavigationManager.NavigateTo("#")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            );
            __builder.OpenComponent<ComponentLib.Pagination>(89);
            __builder.AddAttribute(90, "PagingData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.RequestFeatures.PagingMetaData>(
#nullable restore
#line 63 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                PagingMetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 63 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                              SelectedPageEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(92, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 63 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                                                         2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 64 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
    }
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Confirm>(93);
            __builder.AddAttribute(94, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 67 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                              ConfirmationEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(95, "ConfirmTxt", "Confirm");
            __builder.AddAttribute(96, "Title", "Confirm Delete");
            __builder.AddComponentReferenceCapture(97, (__value) => {
#nullable restore
#line 67 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\Weather\WatherForcastList.razor"
                                                       Confirmation = (ComponentLib.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.Weather.WatherForcastList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGrid_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2)
        {
        __builder.OpenComponent<global::ComponentLib.Grid<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "GridHeader", __arg1);
        __builder.AddAttribute(__seq2, "GridRow", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
