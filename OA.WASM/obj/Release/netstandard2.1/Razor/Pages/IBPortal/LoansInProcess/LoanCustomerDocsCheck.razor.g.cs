#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7398529a1d5fccc0980fa957ed355087e21314a0"
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
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
using OA.Domin.IBPortal.LoanProcessWorkFlow;

#line default
#line hidden
#nullable disable
    public partial class LoanCustomerDocsCheck : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
 if (Control && !InGroup)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ComponentLib.Controls.CheckBoxBtn>(0);
            __builder.AddAttribute(1, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                          AllAproved

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Text", "Approve All");
            __builder.AddAttribute(3, "ClassList", "btn-sm");
            __builder.AddAttribute(4, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 5 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                                                                                      AproveAll

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 6 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                 LoanCustomerDocuments

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "docs-preview");
#nullable restore
#line 11 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
         foreach (var loanDoc in LoanCustomerDocuments)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "doc-preview");
#nullable restore
#line 14 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                 if (Control)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row mb-2");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-6 doc-preview-title");
                __builder2.AddContent(16, 
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                             loanDoc.DocumentName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-md-6");
                __builder2.OpenComponent<ComponentLib.Controls.CheckBoxBtn>(20);
                __builder2.AddAttribute(21, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                                                  (loanDoc.Aproved == true)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Text", "Approve");
                __builder2.AddAttribute(23, "ClassList", "btn-sm");
                __builder2.AddAttribute(24, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 21 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                                                                                                                           (bool check) => { loanDoc.Aproved = check; }

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 24 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "doc-preview-img");
                __builder2.OpenElement(27, "img");
                __builder2.AddAttribute(28, "src", 
#nullable restore
#line 26 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                                $"{PathPrefix}{loanDoc.DocumentPath}"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(29, "style", "width:100%;");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 29 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                 if (Control)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "doc-preview-note");
                __builder2.OpenComponent<ComponentLib.Controls.MInputText>(32);
                __builder2.AddAttribute(33, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 32 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                                                                       () => loanDoc.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 32 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                                                                                                         typeof(LoanCustomerDocument)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "PropName", "Notes");
                __builder2.AddAttribute(36, "Active", "active");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                                                 loanDoc.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loanDoc.Notes = __value, loanDoc.Notes))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loanDoc.Notes));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 34 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 36 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 39 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
     if (Control && !InGroup)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group row mt-5");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-sm-5");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "type", "button");
                __builder2.AddAttribute(46, "class", "btn btn-block btn-sm btn-comp");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                                                                                      ConfirmDocs

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(48, 
#nullable restore
#line 43 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                                                                                                     Localizer["Confirm"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-sm-1 pt-1 text-center");
#nullable restore
#line 46 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                 if (ConfirmBusy)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.MiniLoading>(52);
                __builder2.AddAttribute(53, "size", "25px");
                __builder2.CloseComponent();
#nullable restore
#line 47 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 50 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ServerValidation>(55);
            __builder.AddAttribute(56, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                                            Localizer["Validation"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(57, (__value) => {
#nullable restore
#line 55 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoansInProcess\LoanCustomerDocsCheck.razor"
                        Validation = (ComponentLib.ServerValidation)__value;

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
#pragma warning restore 1591
