#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\JobTypes\JobTypeForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e11ef6dfc0395436304a8fec3f666b2909e249e"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.DSA.Indexes.JobTypes
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
#line 1 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\JobTypes\JobTypeForm.razor"
using OA.Domin.DSA.Indexes;

#line default
#line hidden
#nullable disable
    public partial class JobTypeForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-12");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<ComponentLib.Controls.MInputText>(6);
            __builder.AddAttribute(7, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\JobTypes\JobTypeForm.razor"
                                                      () => JobType.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Id", "Name");
            __builder.AddAttribute(9, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\JobTypes\JobTypeForm.razor"
                                                                                                 typeof(JobType)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "PropName", "Name");
            __builder.AddAttribute(11, "Active", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\JobTypes\JobTypeForm.razor"
                                                                                                                                           Active

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\JobTypes\JobTypeForm.razor"
                                 JobType.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => JobType.Name = __value, JobType.Name))));
            __builder.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => JobType.Name));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group row");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-sm-12");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenComponent<ComponentLib.Controls.MInputText>(24);
            __builder.AddAttribute(25, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 12 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\JobTypes\JobTypeForm.razor"
                                                             () => JobType.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Id", "Description");
            __builder.AddAttribute(27, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 12 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\JobTypes\JobTypeForm.razor"
                                                                                                                      typeof(JobType)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "PropName", "Description");
            __builder.AddAttribute(29, "Active", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\JobTypes\JobTypeForm.razor"
                                                                                                                                                                       Active

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Indexes\JobTypes\JobTypeForm.razor"
                                 JobType.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => JobType.Description = __value, JobType.Description))));
            __builder.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => JobType.Description));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591