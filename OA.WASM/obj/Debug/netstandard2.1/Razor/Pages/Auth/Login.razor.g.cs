#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58209ab36a2749ec489002572f09dcaeedf0e24"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Auth
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
#line 3 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
using OA.WASM.Services.Settings.Extentions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "middle-box");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "box");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "h2");
            __builder.AddContent(10, " ");
            __builder.AddContent(11, 
#nullable restore
#line 8 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                  Localizer["Login"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " . ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(17);
            __builder.AddAttribute(18, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                                 LoginRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                                                              HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(21, "\r\n                    \r\n                    ");
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(22);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n\r\n                    ");
                __builder2.OpenComponent<ComponentLib.ServerValidation>(24);
                __builder2.AddAttribute(25, "Title", "Login result");
                __builder2.AddComponentReferenceCapture(26, (__value) => {
#nullable restore
#line 14 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                                            ServerValidationRef = (ComponentLib.ServerValidation)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n\r\n                    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group row");
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-sm-10 auth-input");
                __builder2.AddMarkupContent(33, "\r\n                            ");
                __builder2.OpenComponent<ComponentLib.Controls.MInputText>(34);
                __builder2.AddAttribute(35, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 18 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                                                                                   () => LoginRequest.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Label", "User Name");
                __builder2.AddAttribute(37, "Id", "UserName");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                                                     LoginRequest.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LoginRequest.UserName = __value, LoginRequest.UserName))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => LoginRequest.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n                    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group row");
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-sm-10 auth-input");
                __builder2.AddMarkupContent(49, "\r\n                            ");
                __builder2.OpenComponent<ComponentLib.Controls.MInputText>(50);
                __builder2.AddAttribute(51, "Type", "password");
                __builder2.AddAttribute(52, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 24 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                                                                                                   () => LoginRequest.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "Label", "Password");
                __builder2.AddAttribute(54, "Id", "Password");
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                                                                     LoginRequest.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LoginRequest.Password = __value, LoginRequest.Password))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => LoginRequest.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n                    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group row mt-5");
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-sm-5");
                __builder2.AddMarkupContent(66, "\r\n                            ");
                __builder2.OpenElement(67, "button");
                __builder2.AddAttribute(68, "type", "submit");
                __builder2.AddAttribute(69, "class", "btn btn-block btn-sm btn-comp");
                __builder2.AddContent(70, " ");
                __builder2.AddContent(71, 
#nullable restore
#line 30 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                                                                                          Localizer["Login"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(72, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-sm-1 pt-1 text-center");
                __builder2.AddMarkupContent(77, "\r\n");
#nullable restore
#line 33 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                             if (LoginBusy)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.MiniLoading>(78);
                __builder2.AddAttribute(79, "size", "25px");
                __builder2.CloseComponent();
#nullable restore
#line 34 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                                                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(80, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 41 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
             if (AppSettings.Check("Registration", "true"))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "                ");
            __builder.OpenElement(86, "div");
            __builder.AddContent(87, " ");
            __builder.AddContent(88, 
#nullable restore
#line 43 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                       Localizer["Not a Member"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(89, " ? ");
            __builder.OpenElement(90, "a");
            __builder.AddAttribute(91, "href", "auth/Register");
            __builder.AddContent(92, " ");
            __builder.AddContent(93, 
#nullable restore
#line 43 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
                                                                             Localizer["Register as Customer"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, " ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 44 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Auth\Login.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
