#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6ba02443143e895cc7e0c157410e2edf434d8d"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.DSA.Pages
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
#line 1 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
using OA.Domin.DSA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
using OA.Domin.Settings;

#line default
#line hidden
#nullable disable
    public partial class PageForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-6");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<ComponentLib.Controls.MInputText>(6);
            __builder.AddAttribute(7, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 7 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                                   () => Page.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Id", "Name");
            __builder.AddAttribute(9, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 7 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                                                                           typeof(Page)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "PropName", "Name");
            __builder.AddAttribute(11, "Active", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                                                                                                                  Active

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                 Page.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Page.Name = __value, Page.Name))));
            __builder.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Page.Name));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-sm-6");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenComponent<ComponentLib.Controls.MInputText>(20);
            __builder.AddAttribute(21, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 10 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                                   () => Page.Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Id", "Type");
            __builder.AddAttribute(23, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 10 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                                                                           typeof(Page)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "PropName", "Type");
            __builder.AddAttribute(25, "Active", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                                                                                                                  Active

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                 Page.Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Page.Type = __value, Page.Type))));
            __builder.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Page.Type));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group row");
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-sm-6");
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenComponent<ComponentLib.Controls.MInputNumber>(38);
            __builder.AddAttribute(39, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Int32>>>(
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                                      () => Page.Order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "Id", "Order");
            __builder.AddAttribute(41, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                                                                                typeof(Page)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "PropName", "Order");
            __builder.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                   Page.Order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Page.Order = __value, Page.Order))));
            __builder.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Int32>>>(() => Page.Order));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-sm-2 offset-1 select-col");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenComponent<ComponentLib.Controls.CheckBoxBtn>(51);
            __builder.AddAttribute(52, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                              Page.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "Text", "Active");
            __builder.AddAttribute(54, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 19 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                                                       (bool value) => Page.IsActive = value

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "form-group row");
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-sm-6");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenComponent<OA.WASM.Shared.UploadFile>(64);
            __builder.AddAttribute(65, "Label", "Image");
            __builder.AddAttribute(66, "Types", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 27 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                           FileSettings.MimeTypes["Image"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "ImagePreview", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "ShowUploaded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                  false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "MaxSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 30 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                             1024 * 1024 * 1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "OnValidUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 31 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                     () => Page.Image = ImageUploadControl.Files[0] 

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(71, "OnStartPreUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 32 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                        () => UploadBusy = true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(72, "OnEndPreUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 33 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                                      () => UploadBusy = false

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(73, (__value) => {
#nullable restore
#line 25 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                          ImageUploadControl = (OA.WASM.Shared.UploadFile)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 34 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
         if (IsEdit)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "            ");
            __builder.OpenElement(76, "div");
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.AddContent(78, 
#nullable restore
#line 37 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
                 Page.ImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 39 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "col-md-6");
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "M-center");
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 43 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
             if (UploadBusy)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "                ");
            __builder.OpenComponent<ComponentLib.MiniLoading>(90);
            __builder.CloseComponent();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 46 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Pages\PageForm.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591