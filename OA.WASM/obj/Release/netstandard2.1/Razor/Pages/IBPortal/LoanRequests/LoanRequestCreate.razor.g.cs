#pragma checksum "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1a6cc80bac7aeb65350a33bd7d3c5681bb9e4b1"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.IBPortal.LoanRequests
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
#line 1 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
using OA.WASM.Pages.IBPortal.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
using OA.Domin.IBPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
using OA.WASM.Pages.IBPortal.LoanRequests.LoanInfos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
using OA.WASM.Pages.IBPortal.LoanRequests.ProjectInfos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
           [Authorize(Policy = "loan-requests-write")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LoanRequest/create")]
    public partial class LoanRequestCreate : LoanRequestCreateBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-title");
            __builder.AddContent(2, 
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                          Localizer["Create"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " ");
            __builder.AddContent(4, 
#nullable restore
#line 10 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                               Localizer["Loan Request"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                 EntityItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                            HandelSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group row mt-3 mb-5");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-10");
                __Blazor.OA.WASM.Pages.IBPortal.LoanRequests.LoanRequestCreate.TypeInference.CreateMInputSelect_0(__builder2, 16, 17, 
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                          LoanServieItems

#line default
#line hidden
#nullable disable
                , 18, 
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                                  ()=> EntityItem.LoanServiceId

#line default
#line hidden
#nullable disable
                , 19, "LoanServiceId", 20, 
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                                                                                                 typeof(LoanRequest)

#line default
#line hidden
#nullable disable
                , 21, "LoanServiceId", 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                                                                                                                                                                   LoanServiceChanged

#line default
#line hidden
#nullable disable
                ), 23, 
#nullable restore
#line 18 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                        EntityItem.LoanServiceId

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.LoanServiceId = __value, EntityItem.LoanServiceId)), 25, () => EntityItem.LoanServiceId);
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 22 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
     if (EntityItem.LoanServiceId == 2) // Group Loan
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "row mb-5");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-md-10");
                __builder2.OpenComponent<ComponentLib.CollapseContainer>(30);
                __builder2.AddAttribute(31, "Id", "CustomersGroup");
                __builder2.AddAttribute(32, "Title", "Customers Group");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<OA.WASM.Pages.IBPortal.LoanRequests.CustomersGroup>(34);
                    __builder3.AddAttribute(35, "LoanRequest", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.IBPortal.LoanRequest>(
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                     EntityItem

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "CustomerItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.String>>(
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                CustomerItems

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "OnGroupChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 28 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                                               GroupChanged

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(38, "Footer", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<ComponentLib.Controls.IconBtn>(39);
                    __builder3.AddAttribute(40, "ClassList", "btn btn-outline btn-rounded btn-sm px-2");
                    __builder3.AddAttribute(41, "IconClassList", "fas fa-share");
                    __builder3.AddAttribute(42, "data-toggle", "modal");
                    __builder3.AddAttribute(43, "data-target", "#SharedInfoModal");
                    __builder3.AddAttribute(44, "title", "Share Data");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 37 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group row mt-3 mb-5");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-md-10");
                __Blazor.OA.WASM.Pages.IBPortal.LoanRequests.LoanRequestCreate.TypeInference.CreateMInputSelect_1(__builder2, 49, 50, 
#nullable restore
#line 42 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                           CustomerItems

#line default
#line hidden
#nullable disable
                , 51, 
#nullable restore
#line 42 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                                 ()=> EntityItem.CustomerId

#line default
#line hidden
#nullable disable
                , 52, "CustomerId", 53, "Customer", 54, 
#nullable restore
#line 42 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                            EntityItem.CustomerId

#line default
#line hidden
#nullable disable
                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EntityItem.CustomerId = __value, EntityItem.CustomerId)), 56, () => EntityItem.CustomerId);
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 45 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
     if (EntityItem.LoanServiceId == 2)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "row mt-3 mb-3");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-md-10");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "detail-key");
                __builder2.AddContent(63, 
#nullable restore
#line 52 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                          Localizer["Group Head Loan"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 55 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.CollapseContainer>(64);
                __builder2.AddAttribute(65, "Title", "Basic Loan Information");
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 59 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
         if (EntityItem != null && EntityItem.LoanInfo != null)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<OA.WASM.Pages.IBPortal.LoanRequests.LoanInfos.LoanInfoCreate>(67);
                    __builder3.AddAttribute(68, "LoanInfo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.IBPortal.LoanInfo>(
#nullable restore
#line 61 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                      EntityItem.LoanInfo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "InstitutionIdentificationWayItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.String>>(
#nullable restore
#line 61 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                              InstitutionIdentificationWayItems

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 62 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n\r\n    ");
                __builder2.OpenComponent<ComponentLib.CollapseContainer>(71);
                __builder2.AddAttribute(72, "Title", "Project Info");
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 68 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
         if (EntityItem != null && EntityItem.ProjectInfo != null)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<OA.WASM.Pages.IBPortal.LoanRequests.ProjectInfos.ProjectInfoCreate>(74);
                    __builder3.AddAttribute(75, "ProjectInfo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.IBPortal.ProjectInfo>(
#nullable restore
#line 70 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                            EntityItem.ProjectInfo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "ProjectStateItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.String>>(
#nullable restore
#line 70 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                       ProjectStateItems

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 71 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 74 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
     if (EntityItem != null && EntityItem.LoanServiceId == 2 && EntityItem.GroupLoanCustomers != null)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "row mb-3 mt-3");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col-md-10");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "detail-key");
                __builder2.AddContent(83, 
#nullable restore
#line 78 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                          Localizer["Group Memebers Loans"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "mt-4 pt-4 pb-5 loan-tabs");
                __Blazor.OA.WASM.Pages.IBPortal.LoanRequests.LoanRequestCreate.TypeInference.CreateSequentialTabs_2(__builder2, 87, 88, 
#nullable restore
#line 82 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                      GroupLoanCustomersTabs

#line default
#line hidden
#nullable disable
                , 89, "text-center", 90, 
#nullable restore
#line 82 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                                                                   true

#line default
#line hidden
#nullable disable
                , 91, "loan-tabs-panel-wrapper pb-3 pt-3", 92, (tabContext) => (__builder3) => {
                    __builder3.OpenElement(93, "div");
                    __builder3.AddAttribute(94, "class", "detail-key mt-3 mb-3");
                    __builder3.AddContent(95, 
#nullable restore
#line 87 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                         Localizer["Group Member"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(96, " :\r\n\r\n");
#nullable restore
#line 89 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                         if (tabContext.CustomerId != null && CustomerItems.ContainsKey(tabContext.CustomerId.ToString()))
                        {
                            

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(97, 
#nullable restore
#line 91 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                             CustomerItems[tabContext.CustomerId.ToString()]

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 91 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                            
                        }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\r\n\r\n                    ");
                    __builder3.OpenComponent<ComponentLib.CollapseContainer>(99);
                    __builder3.AddAttribute(100, "Title", "Group Member Loan Info");
                    __builder3.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<OA.WASM.Pages.IBPortal.LoanRequests.LoanInfos.LoanInfoCreate>(102);
                        __builder4.AddAttribute(103, "LoanInfo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.IBPortal.LoanInfo>(
#nullable restore
#line 97 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                  tabContext.LoanInfo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(104, "InstitutionIdentificationWayItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.String>>(
#nullable restore
#line 97 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                                          InstitutionIdentificationWayItems

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\r\n\r\n                    ");
                    __builder3.OpenComponent<ComponentLib.CollapseContainer>(106);
                    __builder3.AddAttribute(107, "Title", "Group Member Project Info");
                    __builder3.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<OA.WASM.Pages.IBPortal.LoanRequests.ProjectInfos.ProjectInfoCreate>(109);
                        __builder4.AddAttribute(110, "ProjectInfo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.IBPortal.ProjectInfo>(
#nullable restore
#line 101 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                        tabContext.ProjectInfo

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(111, "ProjectStateItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.String>>(
#nullable restore
#line 101 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                                   ProjectStateItems

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                );
                __builder2.CloseElement();
#nullable restore
#line 107 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-group row mt-5");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "col-sm-5");
                __builder2.OpenElement(116, "button");
                __builder2.AddAttribute(117, "type", "submit");
                __builder2.AddAttribute(118, "class", "btn btn-block btn-sm btn-comp");
                __builder2.AddContent(119, 
#nullable restore
#line 112 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                          Localizer["Create"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n        ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "col-sm-1 pt-1 text-center");
#nullable restore
#line 115 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
             if (CreateBusy)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<ComponentLib.MiniLoading>(123);
                __builder2.AddAttribute(124, "size", "25px");
                __builder2.CloseComponent();
#nullable restore
#line 116 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(125, "\r\n\r\n");
            __builder.OpenElement(126, "a");
            __builder.AddAttribute(127, "class", "btn btn-comp-s btn-sm");
            __builder.AddAttribute(128, "href", "/LoanRequestsList");
            __builder.AddContent(129, 
#nullable restore
#line 121 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                            Localizer["Back to list"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\r\n");
            __builder.OpenComponent<ComponentLib.ModalContainer>(131);
            __builder.AddAttribute(132, "Id", "SharedInfoModal");
            __builder.AddAttribute(133, "Size", "lg");
            __builder.AddAttribute(134, "Title", "Shared Data");
            __builder.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(136);
                __builder2.AddAttribute(137, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 124 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                     LoanSharedInfo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(138, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<OA.WASM.Pages.IBPortal.LoanRequests.LoanInfos.LoanInfoCreate>(139);
                    __builder3.AddAttribute(140, "LoanInfo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.IBPortal.LoanInfo>(
#nullable restore
#line 126 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                  LoanSharedInfo.LoanInfo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(141, "InstitutionIdentificationWayItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.String>>(
#nullable restore
#line 126 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                              InstitutionIdentificationWayItems

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(142, "\r\n\r\n        ");
                    __builder3.OpenComponent<OA.WASM.Pages.IBPortal.LoanRequests.ProjectInfos.ProjectInfoCreate>(143);
                    __builder3.AddAttribute(144, "ProjectInfo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OA.Domin.IBPortal.ProjectInfo>(
#nullable restore
#line 128 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                        LoanSharedInfo.ProjectInfo

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(145, "ProjectStateItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.String>>(
#nullable restore
#line 128 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                       ProjectStateItems

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\r\n\r\n        ");
                    __builder3.OpenElement(147, "div");
                    __builder3.AddAttribute(148, "class", "form-group row mt-5");
                    __builder3.OpenElement(149, "div");
                    __builder3.AddAttribute(150, "class", "col-sm-5");
                    __builder3.OpenComponent<ComponentLib.Controls.Btn>(151);
                    __builder3.AddAttribute(152, "type", "button");
                    __builder3.AddAttribute(153, "ClassList", "btn-sm btn-block");
                    __builder3.AddAttribute(154, "Text", "Share");
                    __builder3.AddAttribute(155, "ClickCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 132 "D:\Al Ibda3 Bank Portal\OA_sln\OA.WASM\Pages\IBPortal\LoanRequests\LoanRequestCreate.razor"
                                                                                            ShareInfo

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.IBPortal.LoanRequests.LoanRequestCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMInputSelect_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Type __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg8)
        {
        __builder.OpenComponent<global::ComponentLib.Controls.MInputSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "EntityType", __arg3);
        __builder.AddAttribute(__seq4, "PropName", __arg4);
        __builder.AddAttribute(__seq5, "ValueSelectedEvent", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMInputSelect_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg6)
        {
        __builder.OpenComponent<global::ComponentLib.Controls.MInputSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "Label", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateSequentialTabs_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.Dictionary<global::System.String, TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg4)
        {
        __builder.OpenComponent<global::ComponentLib.SequentialTabs<TItem>>(seq);
        __builder.AddAttribute(__seq0, "TabsData", __arg0);
        __builder.AddAttribute(__seq1, "PanelNavClassList", __arg1);
        __builder.AddAttribute(__seq2, "DynamicContect", __arg2);
        __builder.AddAttribute(__seq3, "PanelWrapperClassList", __arg3);
        __builder.AddAttribute(__seq4, "TabTemplate", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591