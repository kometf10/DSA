#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f2f6af61a2d4eabfc52796094a3c2d0a585b941"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.DSA.Attachments
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
#line 1 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
using OA.Domin.DSA;

#line default
#line hidden
#nullable disable
    public partial class AttachmentForm : Microsoft.AspNetCore.Components.ComponentBase
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
#line 5 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                         () => Attachment.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Id", "Name");
            __builder.AddAttribute(9, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 5 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                                       typeof(Attachment)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "PropName", "Name");
            __builder.AddAttribute(11, "Active", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                                                                                    Active

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                 Attachment.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Attachment.Name = __value, Attachment.Name))));
            __builder.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Attachment.Name));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-sm-6 select-col");
            __builder.AddMarkupContent(19, "\r\n        ");
            __Blazor.OA.WASM.Pages.DSA.Attachments.AttachmentForm.TypeInference.CreateMInputSelect_0(__builder, 20, 21, 
#nullable restore
#line 8 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                           () => Attachment.Type

#line default
#line hidden
#nullable disable
            , 22, 
#nullable restore
#line 8 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                          OA.Domin.StaticIndexes.AttachmentTypes

#line default
#line hidden
#nullable disable
            , 23, "Type", 24, 
#nullable restore
#line 8 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                                                                                        typeof(Attachment)

#line default
#line hidden
#nullable disable
            , 25, "Type", 26, 
#nullable restore
#line 8 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                   Attachment.Type

#line default
#line hidden
#nullable disable
            , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Attachment.Type = __value, Attachment.Type)), 28, () => Attachment.Type);
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
#line 14 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                            () => Attachment.Order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "Id", "Order");
            __builder.AddAttribute(41, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 14 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                                            typeof(Attachment)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "PropName", "Order");
            __builder.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                   Attachment.Order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Attachment.Order = __value, Attachment.Order))));
            __builder.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Int32>>>(() => Attachment.Order));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-sm-6");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenComponent<ComponentLib.Controls.MInputText>(51);
            __builder.AddAttribute(52, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(
#nullable restore
#line 17 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                        () => Attachment.URL

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "Id", "URL");
            __builder.AddAttribute(54, "EntityType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 17 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                                    typeof(Attachment)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "PropName", "URL");
            __builder.AddAttribute(56, "Active", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                                                                                Active

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                 Attachment.URL

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Attachment.URL = __value, Attachment.URL))));
            __builder.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Attachment.URL));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group row");
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-sm-6 select-col");
            __builder.AddMarkupContent(68, "\r\n        ");
            __Blazor.OA.WASM.Pages.DSA.Attachments.AttachmentForm.TypeInference.CreateMInputSelect_1(__builder, 69, 70, 
#nullable restore
#line 23 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                () => Attachment.Reference

#line default
#line hidden
#nullable disable
            , 71, 
#nullable restore
#line 23 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                                    OA.Domin.StaticIndexes.AttachemntReferences

#line default
#line hidden
#nullable disable
            , 72, "Reference", 73, 
#nullable restore
#line 23 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                                                                                                            typeof(Attachment)

#line default
#line hidden
#nullable disable
            , 74, "Reference", 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 23 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                                                                                                                                                                         ReferenceSelected

#line default
#line hidden
#nullable disable
            ), 76, 
#nullable restore
#line 23 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                   Attachment.Reference

#line default
#line hidden
#nullable disable
            , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Attachment.Reference = __value, Attachment.Reference)), 78, () => Attachment.Reference);
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 25 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
     if(Initilzed && !string.IsNullOrEmpty(Attachment.Reference) && References.Keys.Contains(Attachment.Reference)) { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "col-sm-6 select-col");
            __builder.AddMarkupContent(84, "            \r\n            ");
            __Blazor.OA.WASM.Pages.DSA.Attachments.AttachmentForm.TypeInference.CreateMInputSelect_2(__builder, 85, 86, 
#nullable restore
#line 27 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                      () => Attachment.ReferenceId

#line default
#line hidden
#nullable disable
            , 87, 
#nullable restore
#line 27 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                                            References[Attachment.Reference]

#line default
#line hidden
#nullable disable
            , 88, "ReferenceId", 89, 
#nullable restore
#line 27 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                                                                                                                                                           typeof(Attachment)

#line default
#line hidden
#nullable disable
            , 90, "ReferenceId", 91, 
#nullable restore
#line 27 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                       Attachment.ReferenceId

#line default
#line hidden
#nullable disable
            , 92, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Attachment.ReferenceId = __value, Attachment.ReferenceId)), 93, () => Attachment.ReferenceId);
            __builder.AddMarkupContent(94, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 29 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "form-group row mt-4");
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "col-sm-8");
            __builder.AddMarkupContent(102, "\r\n        ");
            __builder.OpenComponent<OA.WASM.Shared.UploadFile>(103);
            __builder.AddAttribute(104, "Label", "File");
            __builder.AddAttribute(105, "ImagePreview", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                  false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "ShowUploaded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "MaxSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 38 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                             1024 * 1024 * 25

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "OnValidUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 39 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                     () => Attachment.File = FileUploadControl.Files[0] 

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(109, "OnStartPreUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 40 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                        () => UploadBusy = true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(110, "OnEndPreUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 41 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                                      () => UploadBusy = false

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(111, (__value) => {
#nullable restore
#line 34 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                          FileUploadControl = (OA.WASM.Shared.UploadFile)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(112, "\r\n");
#nullable restore
#line 42 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
         if (IsEdit)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "            ");
            __builder.OpenElement(114, "div");
            __builder.AddMarkupContent(115, "\r\n                ");
            __builder.AddContent(116, 
#nullable restore
#line 45 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
                 Attachment.Path

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 47 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n    ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "col-sm-4");
            __builder.AddMarkupContent(123, "\r\n        ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "M-center");
            __builder.AddMarkupContent(126, "\r\n");
#nullable restore
#line 51 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
             if (UploadBusy)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "                ");
            __builder.OpenComponent<ComponentLib.MiniLoading>(128);
            __builder.CloseComponent();
            __builder.AddMarkupContent(129, "\r\n");
#nullable restore
#line 54 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\DSA\Attachments\AttachmentForm.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(130, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.OA.WASM.Pages.DSA.Attachments.AttachmentForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMInputSelect_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Type __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg7)
        {
        __builder.OpenComponent<global::ComponentLib.Controls.MInputSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "EntityType", __arg3);
        __builder.AddAttribute(__seq4, "PropName", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateMInputSelect_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Type __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg8)
        {
        __builder.OpenComponent<global::ComponentLib.Controls.MInputSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "EntityType", __arg3);
        __builder.AddAttribute(__seq4, "PropName", __arg4);
        __builder.AddAttribute(__seq5, "ValueSelectedEvent", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMInputSelect_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Type __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg7)
        {
        __builder.OpenComponent<global::ComponentLib.Controls.MInputSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "EntityType", __arg3);
        __builder.AddAttribute(__seq4, "PropName", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591