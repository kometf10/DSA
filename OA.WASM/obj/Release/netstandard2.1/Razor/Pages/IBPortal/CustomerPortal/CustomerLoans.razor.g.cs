#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed729012c950fbe9ab7821239626a5df2dd4f6b7"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.IBPortal.CustomerPortal
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
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
using OA.Domin.IBPortal.LoanProcessWorkFlow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
           [Authorize(Policy = "bank-customer")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CustomerLoans")]
    public partial class CustomerLoans : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"page-title\"> Your Loans </div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "loan-cards-container");
#nullable restore
#line 9 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
       int i = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
     foreach (var loan in Loans)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card loan-card");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-num");
            __builder.AddContent(9, " 0 ");
            __builder.AddContent(10, 
#nullable restore
#line 14 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                          i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-title");
            __builder.AddContent(14, 
#nullable restore
#line 16 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                          loan.RequestedAmount?.ToString("#,##0")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddContent(17, 
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                       Localizer[loan.State]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddContent(20, 
#nullable restore
#line 20 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                       Localizer[loan.LoanService]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n                ");
            __builder.OpenElement(22, "div");
            __builder.AddContent(23, 
#nullable restore
#line 22 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                       loan.RequestDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                 if (loan.CanChange)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                     if (loan.State == WorkFlowNames.STATE_PENDING_CUSTOMER_UPLOAD)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(24);
            __builder.AddAttribute(25, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(26, "IconClassList", "fas fa-upload");
            __builder.AddAttribute(27, "data-backdrop", "static");
            __builder.AddAttribute(28, "data-target", "#LoanDocsModal");
            __builder.AddAttribute(29, "data-toggle", "modal");
            __builder.AddAttribute(30, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                                                                                                                                                                                            () => { OnUploadClick(loan); }

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                     if (!WorkFlowNames.EndStates.Contains(loan.State) && loan.State != WorkFlowNames.STATE_PENDING_BRANCHMAN_CANCEL_CONFIRM)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Controls.IconBtn>(31);
            __builder.AddAttribute(32, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
            __builder.AddAttribute(33, "IconClassList", "fa fa-times");
            __builder.AddAttribute(34, "title", "Cancel The Loan Request");
            __builder.AddAttribute(35, "data-backdrop", "static");
            __builder.AddAttribute(36, "data-target", "#LoanCancelModal");
            __builder.AddAttribute(37, "data-toggle", "modal");
            __builder.AddAttribute(38, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 32 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                                                                                                                                                                                                                             () => { CurrentLoanProcessId = loan.LoanProcessId; }

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 33 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
        i++;
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ModalContainer>(40);
            __builder.AddAttribute(41, "Title", "Loan Documents");
            __builder.AddAttribute(42, "Id", "LoanDocsModal");
            __builder.AddAttribute(43, "Size", "lg");
            __builder.AddAttribute(44, "CloseEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 41 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                                                                OnModalClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 43 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
     if(CurrentLoanProcessId != 0 && CurrentLoanState == WorkFlowNames.STATE_PENDING_CUSTOMER_UPLOAD)
    {
        if (isGroup)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<OA.WASM.Pages.IBPortal.CustomerPortal.GroupHeadLoanDocs>(46);
                __builder2.AddAttribute(47, "LoanProcessId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                              CurrentLoanProcessId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "Customers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<OA.Domin.IndexData>>(
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                                                               CurrentGroupMembers

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "OnGroupDocsUploaded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                                                                                                         DocsUploaded

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 48 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<OA.WASM.Pages.IBPortal.CustomerPortal.CustomerLoanDocs>(50);
                __builder2.AddAttribute(51, "LoanProcessId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 51 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                             CurrentLoanProcessId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "CustomerId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 51 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                                                               HeadCustomerId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "OnDocsUploaded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 51 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                                                                                               DocsUploaded

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 52 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
        }
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ModalContainer>(55);
            __builder.AddAttribute(56, "Title", "Loan Cancelation Request");
            __builder.AddAttribute(57, "Id", "LoanCancelModal");
            __builder.AddAttribute(58, "Size", "lg");
            __builder.AddAttribute(59, "CloseEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 57 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                                                                            OnModalClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 59 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
     if (CurrentLoanProcessId != 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<OA.WASM.Pages.IBPortal.CustomerPortal.LoanCancelationRequest>(61);
                __builder2.AddAttribute(62, "LoanProcessId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 61 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                               CurrentLoanProcessId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "OnCancelationSubmitted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 61 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
                                                                                             CancelationSubmitted

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 62 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\CustomerPortal\CustomerLoans.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
