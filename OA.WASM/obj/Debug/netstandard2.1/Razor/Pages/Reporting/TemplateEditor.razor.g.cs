#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30d5c9c7718bfff2ee1982ea09617fb953019f50"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Reporting
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
    public partial class TemplateEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "tamplate-editor-con");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "report-options-con");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<button class=\"btn btn-outline btn-rounded btn-sm comp-icon-btn px-2\" data-toggle=\"modal\" data-target=\"#EditTemplateName\">\r\n            <i class=\"fas fa-pen\"> </i>\r\n        </button>\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-outline btn-rounded btn-sm comp-icon-btn px-2");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                                        DeleteTemplate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<i class=\"fas fa-trash\"> </i>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-outline btn-rounded btn-sm comp-icon-btn px-2");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                                        ChangeTemplateState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 13 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
             if (ReportTemplate.Status) 
            { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                ");
            __builder.OpenElement(18, "i");
            __builder.AddContent(19, " ");
            __builder.AddContent(20, 
#nullable restore
#line 15 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                     Localizer["Active"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, " \r\n");
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
            } else { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "i");
            __builder.AddContent(25, " ");
            __builder.AddContent(26, 
#nullable restore
#line 17 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                     Localizer["Passive"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, " \r\n");
#nullable restore
#line 18 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
            } 

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "report-headers-con");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<button class=\"btn btn-outline btn-rounded btn-sm comp-icon-btn px-2\" data-toggle=\"modal\" data-target=\"#AddHeaderModal\">\r\n            <i class=\"fas fa-plus\"> </i>\r\n        </button>\r\n        ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "section-title");
            __builder.AddContent(38, " ");
            __builder.AddContent(39, 
#nullable restore
#line 26 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                      Localizer["Report Headers"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(40, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n");
#nullable restore
#line 28 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
         foreach (var item in ReportTemplate.ReportHeaders)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row report-header");
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-md-10 report-header-text");
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.AddContent(49, 
#nullable restore
#line 32 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                     item.Header

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-md-2");
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.AddMarkupContent(55, "<button class=\"close header-edit-icon\" data-toggle=\"modal\" data-target=\"#EditHeaderModal\"> <i class=\"fas fa-pen\"> </i> </button>\r\n                    ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "class", "close");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                      () => DeleteHeaedr(item.Id) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(59, " × ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 40 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "report-fields-con");
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenElement(68, "span");
            __builder.AddAttribute(69, "class", "section-title");
            __builder.AddContent(70, " ");
            __builder.AddContent(71, 
#nullable restore
#line 46 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                      Localizer["Report Fields"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(72, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n        ");
            __Blazor.OA.WASM.Pages.Reporting.TemplateEditor.TypeInference.CreateOrdarableList_0(__builder, 74, 75, 
#nullable restore
#line 48 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                     OrderedFields

#line default
#line hidden
#nullable disable
            , 76, "Key", 77, (context) => (__builder2) => {
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "report-field row");
                __builder2.AddMarkupContent(81, "\r\n                    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "col-md-10");
                __builder2.AddMarkupContent(84, "\r\n                        ");
                __builder2.AddContent(85, 
#nullable restore
#line 52 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                         Localizer[context.Value]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(86, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                    ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "col-md-2");
                __builder2.AddMarkupContent(90, "\r\n                        ");
                __builder2.OpenElement(91, "button");
                __builder2.AddAttribute(92, "class", "close");
                __builder2.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                          ()=> RemoveFiled(context.Key)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(94, " × ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n            ");
            }
            , 98, (__value) => {
#nullable restore
#line 48 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                             FieldsOrderList = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(99, "\r\n\r\n        ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "class", "btn btn-sm btn-comp");
            __builder.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                      SaveFields

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(103, " ");
            __builder.AddContent(104, 
#nullable restore
#line 61 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                    Localizer["Save"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(105, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.OpenElement(107, "button");
            __builder.AddAttribute(108, "class", "btn btn-sm btn-comp-s");
            __builder.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                        ResetFields

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(110, " ");
            __builder.AddContent(111, 
#nullable restore
#line 62 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                       Localizer["Reset"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(112, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.Confirm>(116);
            __builder.AddAttribute(117, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 67 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                         DeleteHeaderConfirmEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(118, (__value) => {
#nullable restore
#line 67 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
               DeleteHeaderConfirm = (ComponentLib.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(119, "\r\n");
            __builder.OpenComponent<ComponentLib.Confirm>(120);
            __builder.AddAttribute(121, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 68 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                           DeleteTemplateConfirmEvent

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(122, (__value) => {
#nullable restore
#line 68 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
               DeleteTemplateConfirm = (ComponentLib.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(123, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ModalContainer>(124);
            __builder.AddAttribute(125, "Id", "AddHeaderModal");
            __builder.AddAttribute(126, "Size", "lg");
            __builder.AddAttribute(127, "Title", "Add Report Header");
            __builder.AddAttribute(128, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(129, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(130);
                __builder2.AddAttribute(131, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 71 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                     ReportHeader

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(132, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 71 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                  SaveReportHeader

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(133, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(134, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(135);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(136, "\r\n        ");
                    __builder3.OpenElement(137, "div");
                    __builder3.AddAttribute(138, "class", "row");
                    __builder3.AddMarkupContent(139, "\r\n            ");
                    __builder3.OpenElement(140, "div");
                    __builder3.AddAttribute(141, "class", "col-md-10");
                    __builder3.AddMarkupContent(142, "\r\n                ");
                    __builder3.OpenComponent<ComponentLib.Controls.MInputText>(143);
                    __builder3.AddAttribute(144, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 75 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                     () => ReportHeader.Header

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(145, "Id", "ReportHeader");
                    __builder3.AddAttribute(146, "Label", "Report Header");
                    __builder3.AddAttribute(147, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 75 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                         ReportHeader.Header

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(148, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ReportHeader.Header = __value, ReportHeader.Header))));
                    __builder3.AddAttribute(149, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ReportHeader.Header));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(150, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(151, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(152, "\r\n        ");
                    __builder3.OpenElement(153, "div");
                    __builder3.AddAttribute(154, "class", "row mt-5");
                    __builder3.AddMarkupContent(155, "\r\n            ");
                    __builder3.OpenElement(156, "div");
                    __builder3.AddAttribute(157, "class", "col-md-4");
                    __builder3.AddMarkupContent(158, "\r\n                ");
                    __builder3.OpenElement(159, "button");
                    __builder3.AddAttribute(160, "type", "submit");
                    __builder3.AddAttribute(161, "class", "btn btn-block btn-sm btn-comp");
                    __builder3.AddContent(162, " ");
                    __builder3.AddContent(163, 
#nullable restore
#line 80 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Reporting\TemplateEditor.razor"
                                                                              Localizer["Save"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(164, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(165, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(166, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(167, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(168, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.Reporting.TemplateEditor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateOrdarableList_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<T> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2, int __seq3, global::System.Action<global::ComponentLib.OrdarableList<T>> __arg3)
        {
        __builder.OpenComponent<global::ComponentLib.OrdarableList<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "KeyName", __arg1);
        __builder.AddAttribute(__seq2, "ItemTemplate", __arg2);
        __builder.AddComponentReferenceCapture(__seq3, (__value) => { __arg3((global::ComponentLib.OrdarableList<T>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591