#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff3ed6210973937d891ece236cf353234d5fab1"
// <auto-generated/>
#pragma warning disable 1591
namespace ComponentLib
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#line 1 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 2 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
using ComponentLib.Controls;

#line default
#line hidden
    public partial class GridFilter<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "style");
            __builder.AddMarkupContent(1, "\r\n    .radio-btn {\r\n        color: ");
            __builder.AddContent(2, 
#line 7 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                Theme.MainBackground

#line default
#line hidden
            );
            __builder.AddMarkupContent(3, ";\r\n        border-color: ");
            __builder.AddContent(4, 
#line 8 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                       Theme.MainBackground

#line default
#line hidden
            );
            __builder.AddMarkupContent(5, ";\r\n    }\r\n\r\n    .radio-active {\r\n        background-color: ");
            __builder.AddContent(6, 
#line 12 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                           Theme.MainBackground

#line default
#line hidden
            );
            __builder.AddMarkupContent(7, @";
        color: #FFF;
    }

    add-filter-form {
        background-color: #EEE;
        padding: 10px;
        border: 1px solid #DDD;
        border-radius: 5px;
        color: gray;
    }

    .added-filter {
        background-color: #DDD;
        padding: 15px;
        margin-left: 25px;
        margin-right: 25px;
        margin-top: 10px;
    }

    .filter-card-header{
        padding: 0 !important;
    }
    .filter-toggle-btn{
        text-align: ");
            __builder.AddContent(8, 
#line 36 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                     Theme.Align

#line default
#line hidden
            );
            __builder.AddMarkupContent(9, ";\r\n    }\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, @"<div class=""card-header filter-card-header"" id=""headingOne"">
        <div class=""mb-0"">
            <div class=""btn btn-block filter-toggle-btn"">
                <button class=""comp-icon-btn btn btn-outline btn-rounded btn-sm px-2"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                    <i class=""fas fa-sliders-h""></i>
                </button>
            </div>
        </div>
    </div>

    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "id", "collapseOne");
            __builder.AddAttribute(17, "class", "collapse");
            __builder.AddAttribute(18, "aria-labelledby", "headingOne");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-body");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(23);
            __builder.AddAttribute(24, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 55 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                             Filter

#line default
#line hidden
            ));
            __builder.AddAttribute(25, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 55 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                    AddFilter

#line default
#line hidden
            )));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(28);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n\r\n                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "row add-filter-form");
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-md-3");
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __Blazor.ComponentLib.GridFilter.TypeInference.CreateInputSelect_0(__builder2, 36, 37, 
#line 60 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                        ()=>Filter.ColumnName

#line default
#line hidden
                , 38, 
#line 61 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                             Filter.ColumnName

#line default
#line hidden
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 62 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                     (string value) => SetFilterType(value)

#line default
#line hidden
                ), 40, "form-control", 41, (__builder3) => {
                    __builder3.AddMarkupContent(42, "\r\n                            ");
                    __builder3.OpenElement(43, "option");
                    __builder3.AddAttribute(44, "selected", true);
                    __builder3.AddAttribute(45, "value", true);
                    __builder3.AddContent(46, " ");
                    __builder3.AddContent(47, 
#line 63 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                        Localizer["Filter Field"]

#line default
#line hidden
                    );
                    __builder3.AddContent(48, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n");
#line 64 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                             foreach (var prop in PropNames)
                            {

#line default
#line hidden
                    __builder3.AddContent(50, "                                ");
                    __builder3.OpenElement(51, "option");
                    __builder3.AddAttribute(52, "value", 
#line 66 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                prop.Key

#line default
#line hidden
                    );
                    __builder3.AddContent(53, " ");
                    __builder3.AddContent(54, 
#line 66 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                            Localizer[prop.Value]

#line default
#line hidden
                    );
                    __builder3.AddContent(55, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\r\n");
#line 67 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                            }

#line default
#line hidden
                    __builder3.AddContent(57, "                        ");
                }
                );
                __builder2.AddMarkupContent(58, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n");
#line 70 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                     if (FilterType != null)
                    {

#line default
#line hidden
                __builder2.AddContent(60, "                        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "col-md-3");
                __builder2.AddMarkupContent(63, "\r\n                            ");
                __Blazor.ComponentLib.GridFilter.TypeInference.CreateInputSelect_1(__builder2, 64, 65, "form-control", 66, 
#line 73 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                      Filter.FilterOption

#line default
#line hidden
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filter.FilterOption = __value, Filter.FilterOption)), 68, () => Filter.FilterOption, 69, (__builder3) => {
                    __builder3.AddMarkupContent(70, "\r\n");
#line 74 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                 foreach (var op in TypeOperator)
                                    {

#line default
#line hidden
                    __builder3.AddContent(71, "                                    ");
                    __builder3.OpenElement(72, "option");
                    __builder3.AddAttribute(73, "value", 
#line 76 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                    op.Key

#line default
#line hidden
                    );
                    __builder3.AddContent(74, " ");
                    __builder3.AddContent(75, 
#line 76 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                              Localizer[op.Value]

#line default
#line hidden
                    );
                    __builder3.AddContent(76, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\r\n");
#line 77 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                    }

#line default
#line hidden
                    __builder3.AddContent(78, "                            ");
                }
                );
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                        ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col-md-4");
                __builder2.AddMarkupContent(83, "\r\n");
#line 81 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                             switch (FilterType)
                            {
                                case "STRING":

#line default
#line hidden
                __builder2.AddContent(84, "                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(85);
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "placeholder", 
#line 84 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                                                                                   Localizer["Value"]

#line default
#line hidden
                );
                __builder2.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 84 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                            Filter.FilterValue

#line default
#line hidden
                ));
                __builder2.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filter.FilterValue = __value, Filter.FilterValue))));
                __builder2.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Filter.FilterValue));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n");
#line 85 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                    break;
                                case "DATETIME":

#line default
#line hidden
                __builder2.AddContent(92, "                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(93);
                __builder2.AddAttribute(94, "type", "date");
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 87 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                                        Filter.FilterValue

#line default
#line hidden
                ));
                __builder2.AddAttribute(97, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filter.FilterValue = __value, Filter.FilterValue))));
                __builder2.AddAttribute(98, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Filter.FilterValue));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n");
#line 88 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                    break;
                                case "INT":

#line default
#line hidden
                __builder2.AddContent(100, "                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(101);
                __builder2.AddAttribute(102, "type", "number");
                __builder2.AddAttribute(103, "class", "form-control");
                __builder2.AddAttribute(104, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 90 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                                          Filter.FilterValue

#line default
#line hidden
                ));
                __builder2.AddAttribute(105, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filter.FilterValue = __value, Filter.FilterValue))));
                __builder2.AddAttribute(106, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Filter.FilterValue));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\r\n");
#line 91 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                    break;
                                case "BOOLEAN":

#line default
#line hidden
                __builder2.AddContent(108, "                                    ");
                __Blazor.ComponentLib.GridFilter.TypeInference.CreateInputSelect_2(__builder2, 109, 110, "form-control", 111, 
#line 93 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                              Filter.FilterValue

#line default
#line hidden
                , 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filter.FilterValue = __value, Filter.FilterValue)), 113, () => Filter.FilterValue, 114, (__builder3) => {
                    __builder3.AddMarkupContent(115, "\r\n                                        ");
                    __builder3.OpenElement(116, "option");
                    __builder3.AddAttribute(117, "selected", true);
                    __builder3.AddAttribute(118, "value", true);
                    __builder3.AddContent(119, " ");
                    __builder3.AddContent(120, 
#line 94 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                                    Localizer["Select value"]

#line default
#line hidden
                    );
                    __builder3.AddContent(121, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(122, "\r\n                                        ");
                    __builder3.AddMarkupContent(123, "<option value=\"true\"> True </option>\r\n                                        ");
                    __builder3.AddMarkupContent(124, "<option value=\"false\"> False </option>\r\n                                    ");
                }
                );
                __builder2.AddMarkupContent(125, "\r\n");
#line 98 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                    break;
                                default:

#line default
#line hidden
                __builder2.AddContent(126, "                                    ");
                __Blazor.ComponentLib.GridFilter.TypeInference.CreateInputSelect_3(__builder2, 127, 128, "form-control", 129, 
#line 100 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                              Filter.FilterValue

#line default
#line hidden
                , 130, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filter.FilterValue = __value, Filter.FilterValue)), 131, () => Filter.FilterValue, 132, (__builder3) => {
                    __builder3.AddMarkupContent(133, "\r\n                                        ");
                    __builder3.OpenElement(134, "option");
                    __builder3.AddAttribute(135, "selected", true);
                    __builder3.AddAttribute(136, "value", true);
                    __builder3.AddContent(137, " ");
                    __builder3.AddContent(138, 
#line 101 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                                    Localizer["Select value"]

#line default
#line hidden
                    );
                    __builder3.AddContent(139, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(140, "\r\n");
#line 102 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                         foreach (var item in IndexDatas)
                                        {

#line default
#line hidden
                    __builder3.AddContent(141, "                                            ");
                    __builder3.OpenElement(142, "option");
                    __builder3.AddAttribute(143, "value", 
#line 104 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                            item.Id.ToString()

#line default
#line hidden
                    );
                    __builder3.AddContent(144, " ");
                    __builder3.AddContent(145, 
#line 104 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                                                  item.Name

#line default
#line hidden
                    );
                    __builder3.AddContent(146, " ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(147, "\r\n");
#line 105 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                        }

#line default
#line hidden
                    __builder3.AddContent(148, "                                    ");
                }
                );
                __builder2.AddMarkupContent(149, "\r\n");
#line 107 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                    break;

                            }

#line default
#line hidden
                __builder2.AddContent(150, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n                        ");
                __builder2.OpenElement(152, "div");
                __builder2.AddAttribute(153, "class", "col-md-2");
                __builder2.AddMarkupContent(154, "\r\n                            ");
                __builder2.OpenComponent<ComponentLib.Controls.Btn>(155);
                __builder2.AddAttribute(156, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 112 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                        Localizer["Add"]

#line default
#line hidden
                ));
                __builder2.AddAttribute(157, "ClassList", "btn-sm");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(158, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "                        \r\n");
#line 114 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                    }

#line default
#line hidden
                __builder2.AddContent(160, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "                \r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(162, "\r\n\r\n");
#line 119 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
             foreach (var f in Filters)
                                {

#line default
#line hidden
            __builder.AddContent(163, "                ");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "class", "added-filter row");
            __builder.AddMarkupContent(166, "\r\n                    ");
            __builder.OpenElement(167, "div");
            __builder.AddAttribute(168, "class", "col-md-3");
            __builder.AddContent(169, " ");
            __builder.AddContent(170, 
#line 122 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                            PropNames[f.ColumnName]

#line default
#line hidden
            );
            __builder.AddContent(171, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n                    ");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "col-md-3");
            __builder.AddContent(175, " ");
            __builder.AddContent(176, 
#line 123 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                            f.FilterOption

#line default
#line hidden
            );
            __builder.AddContent(177, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n                    ");
            __builder.OpenElement(179, "div");
            __builder.AddAttribute(180, "class", "col-md-3");
            __builder.AddContent(181, " ");
            __builder.AddContent(182, 
#line 124 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                            f.FilterValue

#line default
#line hidden
            );
            __builder.AddContent(183, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n                    ");
            __builder.OpenElement(185, "div");
            __builder.AddAttribute(186, "class", "col-md-3");
            __builder.AddMarkupContent(187, "\r\n                        ");
            __builder.OpenElement(188, "button");
            __builder.AddAttribute(189, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 126 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                          () => RemoveFilter(f)

#line default
#line hidden
            ));
            __builder.AddAttribute(190, "class", "close");
            __builder.AddContent(191, " × ");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n");
#line 129 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
            }

#line default
#line hidden
            __builder.AddContent(195, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n        ");
            __builder.OpenElement(197, "div");
            __builder.AddAttribute(198, "class", "card-footer");
            __builder.AddMarkupContent(199, "\r\n            ");
            __builder.OpenElement(200, "div");
            __builder.AddAttribute(201, "class", "row");
            __builder.AddMarkupContent(202, "\r\n                ");
            __builder.OpenElement(203, "div");
            __builder.AddAttribute(204, "class", "col-md-4");
            __builder.AddMarkupContent(205, "\r\n");
#line 134 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                     if (Filters.Count > 1)
                    {

#line default
#line hidden
            __builder.AddContent(206, "                        ");
            __builder.OpenElement(207, "button");
            __builder.AddAttribute(208, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 136 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                          () => SetGather(0) 

#line default
#line hidden
            ));
            __builder.AddAttribute(209, "class", "btn" + " btn-sm" + " radio-btn" + " " + (
#line 136 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                                                             (Gather == "AND")? "radio-active" : ""

#line default
#line hidden
            ));
            __builder.AddAttribute(210, "title", "Cross Conditions");
            __builder.AddContent(211, " ^ ");
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\r\n                        ");
            __builder.OpenElement(213, "button");
            __builder.AddAttribute(214, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 137 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                          () => SetGather(1) 

#line default
#line hidden
            ));
            __builder.AddAttribute(215, "class", "btn" + " btn-sm" + " radio-btn" + " " + (
#line 137 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                                                             (Gather == "OR")? "radio-active" : ""

#line default
#line hidden
            ));
            __builder.AddAttribute(216, "title", "Union Conditions");
            __builder.AddContent(217, " U ");
            __builder.CloseElement();
            __builder.AddMarkupContent(218, "\r\n");
#line 138 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                    }

#line default
#line hidden
            __builder.AddContent(219, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n                ");
            __builder.OpenElement(221, "div");
            __builder.AddAttribute(222, "class", "col-md-4");
            __builder.AddMarkupContent(223, "\r\n                    ");
            __builder.OpenComponent<ComponentLib.Controls.Btn>(224);
            __builder.AddAttribute(225, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 141 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                Localizer["Search"]

#line default
#line hidden
            ));
            __builder.AddAttribute(226, "ClassList", "btn-block btn-sm");
            __builder.AddAttribute(227, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 141 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                                                                 Search

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(228, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(229, "\r\n                ");
            __builder.OpenElement(230, "div");
            __builder.AddAttribute(231, "class", "col-md-4");
            __builder.AddMarkupContent(232, "\r\n");
#line 144 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                     if (Filters.Count > 0)
                    {

#line default
#line hidden
            __builder.AddContent(233, "                        ");
            __builder.OpenComponent<ComponentLib.Controls.Btn>(234);
            __builder.AddAttribute(235, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 146 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                    Localizer["Clear"]

#line default
#line hidden
            ));
            __builder.AddAttribute(236, "ClassList", "btn-sm");
            __builder.AddAttribute(237, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 146 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                                                                                          ClearFilters

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(238, "\r\n");
#line 147 "D:\FS\DSA\DSA_APP\OA_sln\ComponentLib\GridFilter.razor"
                    }

#line default
#line hidden
            __builder.AddContent(239, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(240, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(241, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(242, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(243, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ComponentLib.GridFilter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ValueExpression", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
