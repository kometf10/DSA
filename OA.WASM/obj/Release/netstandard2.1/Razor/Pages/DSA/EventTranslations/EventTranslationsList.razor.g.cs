#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f37eb0ea222467e9d60c27db3f6253c28d6be094"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.DSA.EventTranslations
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
#line 1 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
using OA.Domin.DSA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
           [Authorize(Policy = "events-control")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EventTranslations/List")]
    public partial class EventTranslationsList : EventTranslationsListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
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
#line 9 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
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
#line 14 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                               Localizer["Events Translations"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n        ");
            __builder.OpenComponent<ComponentLib.GridFilter<EventTranslation>>(14);
            __builder.AddAttribute(15, "SearchSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<OA.Domin.DataFilter.FilterParams>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<OA.Domin.DataFilter.FilterParams>>(this, 
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                       SearchEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "GetIndexData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                                                  GetIndexDataEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(17, (__value) => {
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                                                                           GridFilterRef = (ComponentLib.GridFilter<EventTranslation>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "filter-link");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(22);
            __builder.AddAttribute(23, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(24, "IconClassList", "fas fa-plus");
            __builder.AddAttribute(25, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                                                                                      () => NavigationManager.NavigateTo("/EventTranslation/Create") 

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "export-links");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(31);
            __builder.AddAttribute(32, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(33, "IconClassList", "far fa-file-excel i-lg");
            __builder.AddAttribute(34, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 23 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                                                                                                 () => Export("Exel", nameof(EventTranslation))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(36);
            __builder.AddAttribute(37, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(38, "IconClassList", "far fa-file-pdf i-lg");
            __builder.AddAttribute(39, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 24 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                                                                                               () => Export("Pdf", nameof(EventTranslation))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 25 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
             if (ExportBusy)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.MiniLoading>(41);
            __builder.AddAttribute(42, "size", "25px");
            __builder.CloseComponent();
#nullable restore
#line 26 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 30 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"

    if (GetBusy)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "        ");
            __builder.OpenComponent<ComponentLib.Loading>(47);
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 34 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "        ");
            __Blazor.OA.WASM.Pages.DSA.EventTranslations.EventTranslationsList.TypeInference.CreateGrid_0(__builder, 50, 51, 
#nullable restore
#line 37 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                     ListData

#line default
#line hidden
#nullable disable
            , 52, (__builder2) => {
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.OpenElement(54, "th");
                __builder2.AddContent(55, " ");
                __builder2.AddContent(56, 
#nullable restore
#line 39 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                      Localizer["Event"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(57, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenElement(59, "th");
                __builder2.AddContent(60, " ");
                __builder2.AddContent(61, 
#nullable restore
#line 40 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                      Localizer["Name"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(62, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.OpenElement(64, "th");
                __builder2.AddContent(65, " ");
                __builder2.AddContent(66, 
#nullable restore
#line 41 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                      Localizer["Language"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.OpenElement(68, "th");
                __builder2.AddContent(69, " ");
                __builder2.AddContent(70, 
#nullable restore
#line 42 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                      Localizer["Slug"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.OpenElement(72, "th");
                __builder2.AddContent(73, " ");
                __builder2.AddContent(74, 
#nullable restore
#line 43 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                      Localizer["Is Active"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.OpenElement(76, "th");
                __builder2.AddContent(77, " ");
                __builder2.AddContent(78, 
#nullable restore
#line 44 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                      Localizer["Options"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(79, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
            }
            , 81, (context) => (__builder2) => {
                __builder2.AddMarkupContent(82, "\r\n                ");
                __builder2.OpenElement(83, "td");
                __builder2.AddContent(84, " ");
                __builder2.OpenElement(85, "span");
                __builder2.AddContent(86, " ");
                __builder2.AddContent(87, 
#nullable restore
#line 47 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                             Localizer["Event"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(88, " ");
                __builder2.CloseElement();
                __builder2.AddContent(89, " ");
                __builder2.AddContent(90, 
#nullable restore
#line 47 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                         context.Event?.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                ");
                __builder2.OpenElement(92, "td");
                __builder2.AddContent(93, " ");
                __builder2.OpenElement(94, "span");
                __builder2.AddContent(95, " ");
                __builder2.AddContent(96, 
#nullable restore
#line 48 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                             Localizer["Name"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(97, " ");
                __builder2.CloseElement();
                __builder2.AddContent(98, " ");
                __builder2.AddContent(99, 
#nullable restore
#line 48 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                        context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                ");
                __builder2.OpenElement(101, "td");
                __builder2.AddContent(102, " ");
                __builder2.OpenElement(103, "span");
                __builder2.AddContent(104, " ");
                __builder2.AddContent(105, 
#nullable restore
#line 49 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                             Localizer["Language"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(106, " ");
                __builder2.CloseElement();
                __builder2.AddContent(107, " ");
                __builder2.AddContent(108, 
#nullable restore
#line 49 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                            context.Language

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                ");
                __builder2.OpenElement(110, "td");
                __builder2.AddContent(111, " ");
                __builder2.OpenElement(112, "span");
                __builder2.AddContent(113, " ");
                __builder2.AddContent(114, 
#nullable restore
#line 50 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                             Localizer["Slug"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(115, " ");
                __builder2.CloseElement();
                __builder2.AddContent(116, " ");
                __builder2.AddContent(117, 
#nullable restore
#line 50 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                        context.Slug

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                ");
                __builder2.OpenElement(119, "td");
                __builder2.AddContent(120, " ");
                __builder2.OpenElement(121, "span");
                __builder2.AddContent(122, " ");
                __builder2.AddContent(123, 
#nullable restore
#line 51 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                             Localizer["Is Active"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(124, " ");
                __builder2.CloseElement();
                __builder2.AddContent(125, " ");
                __builder2.OpenComponent<ComponentLib.CheckMark>(126);
                __builder2.AddAttribute(127, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                                                context.IsActive

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddContent(128, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                ");
                __builder2.OpenElement(130, "td");
                __builder2.AddMarkupContent(131, "\r\n                    ");
                __builder2.OpenComponent<ComponentLib.GridRowOptions>(132);
                __builder2.AddAttribute(133, "EditEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 53 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                 () => NavigationManager.NavigateTo($"/EventTranslation/Edit/{context.Id}")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(134, "DeleteEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 54 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                   () => DeleteItem(context.Id) 

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(135, "DetailsEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 55 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                    () => NavigationManager.NavigateTo($"EventTranslation/Details/{context.Id}")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(136, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n            ");
            }
            );
            __builder.AddMarkupContent(138, "\r\n");
            __builder.AddContent(139, "        ");
            __builder.OpenComponent<ComponentLib.Pagination>(140);
            __builder.AddAttribute(141, "PagingData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.RequestFeatures.PagingMetaData>(
#nullable restore
#line 61 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                PagingMetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(142, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 61 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                              SelectedPageEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(143, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 61 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                                                                                         2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(144, "\r\n");
#nullable restore
#line 62 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
    }
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(145, "\r\n");
            __builder.OpenComponent<ComponentLib.Confirm>(146);
            __builder.AddAttribute(147, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 65 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
                              ConfirmationEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(148, "ConfirmTxt", "Confirm");
            __builder.AddAttribute(149, "Title", "Confirm Delete");
            __builder.AddComponentReferenceCapture(150, (__value) => {
#nullable restore
#line 65 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\EventTranslations\EventTranslationsList.razor"
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
namespace __Blazor.OA.WASM.Pages.DSA.EventTranslations.EventTranslationsList
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
