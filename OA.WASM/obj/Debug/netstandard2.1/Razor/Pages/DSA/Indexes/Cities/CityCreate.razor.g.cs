#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Cities\CityCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7523f9539fd448a29130defa4e5bba07fa84405"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.DSA.Indexes.Cities
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
#line 3 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Cities\CityCreate.razor"
           [Authorize(Policy = "indexes-control")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/City/Create")]
    public partial class CityCreate : CityCreateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-title mt-3 mb-4");
            __builder.AddContent(2, " ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Cities\CityCreate.razor"
                                    Localizer["Create"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 5 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Cities\CityCreate.razor"
                                                         Localizer["City"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Cities\CityCreate.razor"
                 EntityItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Cities\CityCreate.razor"
                                            HandelSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n\r\n    ");
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n\r\n    ");
                __builder2.OpenComponent<OA.WASM.Pages.DSA.Indexes.Cities.CityForm>(15);
                __builder2.AddAttribute(16, "City", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.DSA.Indexes.City>(
#nullable restore
#line 11 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Cities\CityCreate.razor"
                    EntityItem

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n\r\n    ");
                __builder2.OpenComponent<ComponentLib.Controls.SubmitBtn>(18);
                __builder2.AddAttribute(19, "Text", "Create");
                __builder2.AddAttribute(20, "Busy", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Cities\CityCreate.razor"
                                   CreateBusy

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.Controls.Btn>(23);
            __builder.AddAttribute(24, "ClassList", "btn-sm btn-comp-s");
            __builder.AddAttribute(25, "Text", "Back To List");
            __builder.AddAttribute(26, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 17 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\Cities\CityCreate.razor"
                                                                        () => NavigationManager.NavigateTo("/Cities/List")

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
