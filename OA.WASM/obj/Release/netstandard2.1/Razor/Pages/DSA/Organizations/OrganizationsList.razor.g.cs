#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bdebd47ed50f8b054084f048e77c240079797df"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.DSA.Organizations
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
#line 1 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
using OA.Domin.DSA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
           [Authorize(Policy = "donations-control")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Organizations/List")]
    public partial class OrganizationsList : OrganizationsListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
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
#line 9 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
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
#line 14 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                               Localizer["Organizations"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n        ");
            __builder.OpenComponent<ComponentLib.GridFilter<Organization>>(14);
            __builder.AddAttribute(15, "SearchSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<OA.Domin.DataFilter.FilterParams>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<OA.Domin.DataFilter.FilterParams>>(this, 
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                   SearchEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(16, (__value) => {
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                                      GridFilterRef = (ComponentLib.GridFilter<Organization>)__value;

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
#line 19 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                                                                                      () => NavigationManager.NavigateTo("/Organization/Create") 

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
#line 23 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                                                                                                 () => Export("Exel", nameof(Organization))

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
#line 24 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                                                                                               () => Export("Pdf", nameof(Organization))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 25 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
             if (ExportBusy)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.MiniLoading>(40);
            __builder.AddAttribute(41, "size", "25px");
            __builder.CloseComponent();
#nullable restore
#line 26 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
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
#line 30 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"

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
#line 34 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __Blazor.OA.WASM.Pages.DSA.Organizations.OrganizationsList.TypeInference.CreateGrid_0(__builder, 49, 50, 
#nullable restore
#line 37 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
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
#line 39 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
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
#line 40 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                      Localizer["Country"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                ");
                __builder2.OpenElement(62, "th");
                __builder2.AddContent(63, " ");
                __builder2.AddContent(64, 
#nullable restore
#line 41 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                      Localizer["Phone"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenElement(66, "th");
                __builder2.AddContent(67, " ");
                __builder2.AddContent(68, 
#nullable restore
#line 42 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                      Localizer["Person"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                ");
                __builder2.OpenElement(70, "th");
                __builder2.AddContent(71, " ");
                __builder2.AddContent(72, 
#nullable restore
#line 43 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                      Localizer["Options"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(73, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n            ");
            }
            , 75, (context) => (__builder2) => {
                __builder2.AddMarkupContent(76, "\r\n                ");
                __builder2.OpenElement(77, "td");
                __builder2.AddContent(78, " ");
                __builder2.OpenElement(79, "span");
                __builder2.AddContent(80, " ");
                __builder2.AddContent(81, 
#nullable restore
#line 46 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                             Localizer["Name"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(82, " ");
                __builder2.CloseElement();
                __builder2.AddContent(83, " ");
                __builder2.AddContent(84, 
#nullable restore
#line 46 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                        context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(85, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                ");
                __builder2.OpenElement(87, "td");
                __builder2.AddContent(88, " ");
                __builder2.OpenElement(89, "span");
                __builder2.AddContent(90, " ");
                __builder2.AddContent(91, 
#nullable restore
#line 47 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                             Localizer["Country"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(92, " ");
                __builder2.CloseElement();
                __builder2.AddContent(93, " ");
                __builder2.AddContent(94, 
#nullable restore
#line 47 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                           context.Country

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(95, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.OpenElement(97, "td");
                __builder2.AddContent(98, " ");
                __builder2.OpenElement(99, "span");
                __builder2.AddContent(100, " ");
                __builder2.AddContent(101, 
#nullable restore
#line 48 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                             Localizer["Phone"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(102, " ");
                __builder2.CloseElement();
                __builder2.AddContent(103, " ");
                __builder2.AddContent(104, 
#nullable restore
#line 48 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                         context.Phone

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(105, "  ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n                ");
                __builder2.OpenElement(107, "td");
                __builder2.AddContent(108, " ");
                __builder2.OpenElement(109, "span");
                __builder2.AddContent(110, " ");
                __builder2.AddContent(111, 
#nullable restore
#line 49 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                             Localizer["person"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(112, " ");
                __builder2.CloseElement();
                __builder2.AddContent(113, " ");
                __builder2.AddContent(114, 
#nullable restore
#line 49 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                          context.Person?.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(115, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                ");
                __builder2.OpenElement(117, "td");
                __builder2.AddMarkupContent(118, "\r\n                    ");
                __builder2.OpenComponent<ComponentLib.GridRowOptions>(119);
                __builder2.AddAttribute(120, "EditEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 51 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                 () => NavigationManager.NavigateTo($"/Organization/Edit/{context.Id}")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(121, "DeleteEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 52 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                   () => DeleteItem(context.Id) 

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(122, "DetailsEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 53 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                    () => NavigationManager.NavigateTo($"Organization/Details/{context.Id}")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n            ");
            }
            );
            __builder.AddMarkupContent(125, "\r\n");
            __builder.AddContent(126, "        ");
            __builder.OpenComponent<ComponentLib.Pagination>(127);
            __builder.AddAttribute(128, "PagingData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.RequestFeatures.PagingMetaData>(
#nullable restore
#line 59 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                PagingMetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(129, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 59 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                              SelectedPageEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(130, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 59 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                                                                                         2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(131, "\r\n");
#nullable restore
#line 60 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
    }
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(132, "\r\n");
            __builder.OpenComponent<ComponentLib.Confirm>(133);
            __builder.AddAttribute(134, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 63 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
                              ConfirmationEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(135, "ConfirmTxt", "Confirm");
            __builder.AddAttribute(136, "Title", "Confirm Delete");
            __builder.AddComponentReferenceCapture(137, (__value) => {
#nullable restore
#line 63 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Organizations\OrganizationsList.razor"
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
namespace __Blazor.OA.WASM.Pages.DSA.Organizations.OrganizationsList
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
