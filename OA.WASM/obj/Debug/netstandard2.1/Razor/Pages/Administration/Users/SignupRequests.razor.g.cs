#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b59055f400250a30887a31f0c3e4fa2ce2025c4"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Administration.Users
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
#line 3 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
           [Authorize(Policy = "administration-users")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/signupRequests")]
    public partial class SignupRequests : SignupRequestsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
 if (Requests == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<ComponentLib.Loading>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 8 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "position:relative; height:40px");
            __builder.AddAttribute(6, "class", "mb-4");
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "page-title filter-title");
            __builder.AddContent(10, " ");
            __builder.AddContent(11, 
#nullable restore
#line 13 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                                               Localizer["Signup Requests"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.AddContent(15, "    ");
            __Blazor.OA.WASM.Pages.Administration.Users.SignupRequests.TypeInference.CreateGrid_0(__builder, 16, 17, 
#nullable restore
#line 18 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                 Requests

#line default
#line hidden
#nullable disable
            , 18, (__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "th");
                __builder2.AddContent(21, " ");
                __builder2.AddContent(22, 
#nullable restore
#line 20 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                  Localizer["Email"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(23, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "th");
                __builder2.AddContent(26, " ");
                __builder2.AddContent(27, 
#nullable restore
#line 21 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                  Localizer["Date"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(28, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.AddMarkupContent(30, "<th>  </th>\r\n            ");
                __builder2.AddMarkupContent(31, "<th>  </th>\r\n        ");
            }
            , 32, (context) => (__builder2) => {
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, " ");
                __builder2.OpenElement(36, "span");
                __builder2.AddContent(37, " ");
                __builder2.AddContent(38, 
#nullable restore
#line 26 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                         Localizer["Email"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(39, " ");
                __builder2.CloseElement();
                __builder2.AddContent(40, "  ");
                __builder2.AddContent(41, 
#nullable restore
#line 26 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                                                      context.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(42, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, " ");
                __builder2.OpenElement(46, "span");
                __builder2.AddContent(47, " ");
                __builder2.AddContent(48, 
#nullable restore
#line 27 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                         Localizer["Date"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(49, " ");
                __builder2.CloseElement();
                __builder2.AddContent(50, "  ");
                __builder2.AddContent(51, 
#nullable restore
#line 27 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                                                     context.CreatedAt

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(52, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenElement(54, "td");
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.OpenComponent<ComponentLib.Controls.IconBtn>(56);
                __builder2.AddAttribute(57, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
                __builder2.AddAttribute(58, "IconClassList", "fa fa-check");
                __builder2.AddAttribute(59, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 29 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                                                                                                                          () => ConfirmRequest(context)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.OpenElement(62, "td");
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.OpenComponent<ComponentLib.Controls.IconBtn>(64);
                __builder2.AddAttribute(65, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
                __builder2.AddAttribute(66, "IconClassList", "fa fa-times");
                __builder2.AddAttribute(67, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 33 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                                                                                                                          () => DeclineRequest(context)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(68, "data-toggle", "modal");
                __builder2.AddAttribute(69, "data-target", "#DeclineRequestModal");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 39 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "\r\n");
            __builder.OpenComponent<ComponentLib.Confirm>(74);
            __builder.AddAttribute(75, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 42 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                                                  ConfirmationEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(76, (__value) => {
#nullable restore
#line 42 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
               Confirmation = (ComponentLib.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(77, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ModalContainer>(78);
            __builder.AddAttribute(79, "Id", "DeclineRequestModal");
            __builder.AddAttribute(80, "Title", "Decline Signup Request");
            __builder.AddAttribute(81, "Size", "lg");
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(83, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(84);
                __builder2.AddAttribute(85, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 45 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                     Request

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 45 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                                        DeclineRequestConfirmed

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(88, "\r\n        ");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "row");
                    __builder3.AddMarkupContent(91, "\r\n            ");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "col-md-12");
                    __builder3.AddMarkupContent(94, "\r\n                ");
                    __builder3.OpenComponent<ComponentLib.Controls.MInputText>(95);
                    __builder3.AddAttribute(96, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 48 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                                                                () => Request.Reason

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(97, "Label", "Reason");
                    __builder3.AddAttribute(98, "Id", "Reason");
                    __builder3.AddAttribute(99, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                                         Request.Reason

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(100, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Request.Reason = __value, Request.Reason))));
                    __builder3.AddAttribute(101, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Request.Reason));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(103, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(104, "\r\n        ");
                    __builder3.OpenElement(105, "div");
                    __builder3.AddAttribute(106, "class", "form-group row mt-5");
                    __builder3.AddMarkupContent(107, "\r\n            ");
                    __builder3.OpenElement(108, "div");
                    __builder3.AddAttribute(109, "class", "col-sm-5");
                    __builder3.AddMarkupContent(110, "\r\n                ");
                    __builder3.OpenElement(111, "button");
                    __builder3.AddAttribute(112, "type", "submit");
                    __builder3.AddAttribute(113, "class", "btn btn-block btn-sm btn-comp");
                    __builder3.AddContent(114, " ");
                    __builder3.AddContent(115, 
#nullable restore
#line 53 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                                                                              Localizer["Save"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(116, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(117, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(118, "\r\n            ");
                    __builder3.OpenElement(119, "div");
                    __builder3.AddAttribute(120, "class", "col-sm-1 pt-1 text-center");
                    __builder3.AddMarkupContent(121, "\r\n");
#nullable restore
#line 56 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                 if (ChangeBusy)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<ComponentLib.MiniLoading>(122);
                    __builder3.AddAttribute(123, "size", "25px");
                    __builder3.CloseComponent();
#nullable restore
#line 57 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Administration\Users\SignupRequests.razor"
                                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(124, "            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(126, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(127, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.Administration.Users.SignupRequests
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
