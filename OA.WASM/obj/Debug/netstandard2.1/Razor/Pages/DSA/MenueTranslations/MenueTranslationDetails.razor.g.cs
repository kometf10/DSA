#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38249f1ad56cd149ca2348db37bcc861b3daf61c"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.DSA.MenueTranslations
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
#line 1 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
using OA.Domin.DSA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
           [Authorize("menues-control")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MenueTranslation/Details/{id}")]
    public partial class MenueTranslationDetails : MenueTranslationDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-title mb-5");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
     Localizer["Manue Translation"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 7 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                                     Localizer["Details"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<OA.WASM.Shared.DetailItem>(8);
            __builder.AddAttribute(9, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 10 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                        typeof(MenueTranslation)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "PropName", "MenueId");
            __builder.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                                                                             EntityItem.Menue?.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenComponent<OA.WASM.Shared.DetailItem>(13);
            __builder.AddAttribute(14, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 12 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                        typeof(MenueTranslation)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "PropName", "Name");
            __builder.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                                                                          EntityItem.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenComponent<OA.WASM.Shared.DetailItem>(18);
            __builder.AddAttribute(19, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 14 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                        typeof(MenueTranslation)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "PropName", "Language");
            __builder.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                                                                              EntityItem.Language

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenComponent<OA.WASM.Shared.DetailItem>(23);
            __builder.AddAttribute(24, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                        typeof(MenueTranslation)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "PropName", "IsActive");
            __builder.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                                                                              EntityItem.IsActive.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n\r\n");
            __builder.OpenComponent<OA.WASM.Shared.DetailItem>(28);
            __builder.AddAttribute(29, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 18 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                        typeof(MenueTranslation)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "PropName", "HTMLContent");
            __builder.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                                                                                 EntityItem.HTMLContent

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n\r\n\r\n");
            __builder.OpenComponent<ComponentLib.Controls.Btn>(33);
            __builder.AddAttribute(34, "ClassList", "btn-sm btn-comp-s");
            __builder.AddAttribute(35, "Text", "Back To List");
            __builder.AddAttribute(36, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 21 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                                                                        () => NavigationManager.NavigateTo("/MenueTranslations/List")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.Controls.Btn>(38);
            __builder.AddAttribute(39, "ClassList", "btn-sm btn-comp-s");
            __builder.AddAttribute(40, "Text", "Edit");
            __builder.AddAttribute(41, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 23 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\MenueTranslations\MenueTranslationDetails.razor"
                                                                () => NavigationManager.NavigateTo($"/MenueTranslation/Edit/{EntityItem.Id}")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
