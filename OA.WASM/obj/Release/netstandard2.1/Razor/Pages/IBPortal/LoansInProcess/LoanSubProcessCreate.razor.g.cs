#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b76e50b5c7ba5000cd7f2dc945a3eeaf248ab39"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.IBPortal.LoansInProcess
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using ComponentLib.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using OA.Domin.ComponentFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
using OA.Domin.IBPortal.LoanProcessWorkFlow;

#line default
#line hidden
#nullable disable
    public partial class LoanSubProcessCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                 LoanSubProcess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                AddSupProcess

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __Blazor.OA.WASM.Pages.IBPortal.LoansInProcess.LoanSubProcessCreate.TypeInference.CreateInputNumber_0(__builder2, 6, 7, "hide", 8, 
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                           LoanSubProcess.LoanProcessId

#line default
#line hidden
#nullable disable
                , 9, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LoanSubProcess.LoanProcessId = __value, LoanSubProcess.LoanProcessId)), 10, () => LoanSubProcess.LoanProcessId);
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenComponent<ComponentLib.Controls.RadioBtnList>(12);
                __builder2.AddAttribute(13, "Buttons", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.Boolean>>(
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                           ActionRadioList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.Dictionary<System.String, System.Boolean>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.Dictionary<System.String, System.Boolean>>(this, 
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                      ActionChanged

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(15, "ClassList", "btn-block m-2");
                __builder2.CloseComponent();
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
     if (LoanSubProcess.Aproved == true)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group row");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-sm-5");
                __builder2.OpenComponent<ComponentLib.Controls.MNInputDecimal>(20);
                __builder2.AddAttribute(21, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal?>>>(
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                                                  () => LoanSubProcess.AprovedAmmont

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Id", "AprovedAmmont");
                __builder2.AddAttribute(23, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                                                                                                                      typeof(LoanSubProcess)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "PropName", "AprovedAmmont");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal?>(
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                             LoanSubProcess.AprovedAmmont

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Decimal?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Decimal?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LoanSubProcess.AprovedAmmont = __value, LoanSubProcess.AprovedAmmont))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Decimal?>>>(() => LoanSubProcess.AprovedAmmont));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-sm-5");
                __builder2.OpenComponent<ComponentLib.Controls.MNInputNumber>(31);
                __builder2.AddAttribute(32, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Int32?>>>(
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                                                 () => LoanSubProcess.PaymentsCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Id", "PaymentsCount");
                __builder2.AddAttribute(34, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                                                                                                                     typeof(LoanSubProcess)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "PropName", "PaymentsCount");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 19 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                            LoanSubProcess.PaymentsCount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LoanSubProcess.PaymentsCount = __value, LoanSubProcess.PaymentsCount))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Int32?>>>(() => LoanSubProcess.PaymentsCount));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 22 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group row");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col-sm-10");
                __builder2.OpenComponent<ComponentLib.Controls.MInputText>(43);
                __builder2.AddAttribute(44, "MultiLine", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                                                   () => LoanSubProcess.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "Id", "Notes");
                __builder2.AddAttribute(47, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                                                                                                       typeof(LoanSubProcess)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "PropName", "Notes");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                      LoanSubProcess.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LoanSubProcess.Notes = __value, LoanSubProcess.Notes))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => LoanSubProcess.Notes));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n    ");
                __builder2.OpenComponent<OA.WASM.Pages.IBPortal.LoansInProcess.LoanAmountInfo>(53);
                __builder2.AddAttribute(54, "LoanProcess", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.IBPortal.ViewModels.InProcessLoan>(
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                 LoanProcess

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "LoanSubProcess", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.IBPortal.LoanProcessWorkFlow.LoanSubProcess>(
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                              LoanSubProcess

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n    \r\n    ");
                __builder2.OpenComponent<ComponentLib.CollapseContainer>(57);
                __builder2.AddAttribute(58, "Id", "PrevProcesses");
                __builder2.AddAttribute(59, "Show", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "Title", "Previous Loan Sub-Processes");
                __builder2.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<OA.WASM.Pages.IBPortal.LoansInProcess.LoanUserSubProcesses>(62);
                    __builder3.AddAttribute(63, "LoanProcessId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                             LoanProcessId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "alert alert-info m-4");
                __builder2.AddContent(67, 
#nullable restore
#line 51 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
         OperationMsg

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group row mt-5");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "col-sm-5");
                __builder2.OpenElement(73, "button");
                __builder2.AddAttribute(74, "type", "submit");
                __builder2.AddAttribute(75, "class", "btn btn-block btn-sm btn-comp");
                __builder2.AddContent(76, 
#nullable restore
#line 56 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                                                          Localizer["Confirm"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "col-sm-1 pt-1 text-center");
#nullable restore
#line 59 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
             if (CreateBusy)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.MiniLoading>(80);
                __builder2.AddAttribute(81, "size", "25px");
                __builder2.CloseComponent();
#nullable restore
#line 60 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanSubProcessCreate.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ServerValidation>(83);
            __builder.AddAttribute(84, "Title", "Validation");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.IBPortal.LoansInProcess.LoanSubProcessCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591