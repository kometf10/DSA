#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be305b14815c07eacbb0ec56a018399f334acec0"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.DSA.Indexes.Activities
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
using OA.Domin.DSA.Indexes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
           [Authorize(Policy = "indexes-control")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Activities/List")]
    public partial class ActivitiesList : ActivitiesListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
 if (ListData == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<ComponentLib.Loading>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 9 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "position:relative");
            __builder.AddAttribute(6, "class", "mb-4");
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "page-title filter-title");
            __builder.AddContent(10, " ");
            __builder.AddContent(11, 
#nullable restore
#line 14 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                               Localizer["Activities"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n        ");
            __builder.OpenComponent<ComponentLib.GridFilter<Activity>>(14);
            __builder.AddAttribute(15, "SearchSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<OA.Domin.DataFilter.FilterParams>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<OA.Domin.DataFilter.FilterParams>>(this, 
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                               SearchEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(16, (__value) => {
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                                                  GridFilterRef = (ComponentLib.GridFilter<Activity>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "filter-link");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(21);
            __builder.AddAttribute(22, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(23, "IconClassList", "fas fa-plus");
            __builder.AddAttribute(24, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                                                                                                      () => NavigationManager.NavigateTo("/Activity/Create") 

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "export-links");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(30);
            __builder.AddAttribute(31, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(32, "IconClassList", "far fa-file-excel i-lg");
            __builder.AddAttribute(33, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 23 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                                                                                                                 () => Export("Exel", nameof(Activity))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(35);
            __builder.AddAttribute(36, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(37, "IconClassList", "far fa-file-pdf i-lg");
            __builder.AddAttribute(38, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 24 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                                                                                                               () => Export("Pdf", nameof(Activity))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 25 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
             if (ExportBusy)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.MiniLoading>(40);
            __builder.AddAttribute(41, "size", "25px");
            __builder.CloseComponent();
#nullable restore
#line 26 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 30 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"

    if (GetBusy)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "        ");
            __builder.OpenComponent<ComponentLib.Loading>(46);
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 34 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __Blazor.OA.WASM.Pages.DSA.Indexes.Activities.ActivitiesList.TypeInference.CreateGrid_0(__builder, 49, 50, 
#nullable restore
#line 37 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                     ListData

#line default
#line hidden
#nullable disable
            , 51, (__builder2) => {
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.OpenElement(53, "th");
                __builder2.AddContent(54, " ");
                __builder2.AddContent(55, 
#nullable restore
#line 39 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                      Localizer["Name"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(56, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                ");
                __builder2.OpenElement(58, "th");
                __builder2.AddContent(59, " ");
                __builder2.AddContent(60, 
#nullable restore
#line 40 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                      Localizer["Options"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(61, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n            ");
            }
            , 63, (context) => (__builder2) => {
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.OpenElement(65, "td");
                __builder2.AddContent(66, " ");
                __builder2.OpenElement(67, "span");
                __builder2.AddContent(68, " ");
                __builder2.AddContent(69, 
#nullable restore
#line 43 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                             Localizer["Name"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(70, " ");
                __builder2.CloseElement();
                __builder2.AddContent(71, " ");
                __builder2.AddContent(72, 
#nullable restore
#line 43 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                                        context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                ");
                __builder2.OpenElement(74, "td");
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.OpenComponent<ComponentLib.GridRowOptions>(76);
                __builder2.AddAttribute(77, "EditEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 45 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                                 () => NavigationManager.NavigateTo($"/Activity/Edit/{context.Id}")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(78, "DeleteEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 46 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                                   () => DeleteItem(context.Id) 

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
            }
            );
            __builder.AddMarkupContent(81, "\r\n");
            __builder.AddContent(82, "        ");
            __builder.OpenComponent<ComponentLib.Pagination>(83);
            __builder.AddAttribute(84, "PagingData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.RequestFeatures.PagingMetaData>(
#nullable restore
#line 52 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                PagingMetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 52 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                                              SelectedPageEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(86, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 52 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                                                                                         2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 53 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
    }
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(88, "\r\n");
            __builder.OpenComponent<ComponentLib.Confirm>(89);
            __builder.AddAttribute(90, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 56 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
                              ConfirmationEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(91, "ConfirmTxt", "Confirm");
            __builder.AddAttribute(92, "Title", "Confirm Delete");
            __builder.AddComponentReferenceCapture(93, (__value) => {
#nullable restore
#line 56 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Activities\ActivitiesList.razor"
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
namespace __Blazor.OA.WASM.Pages.DSA.Indexes.Activities.ActivitiesList
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