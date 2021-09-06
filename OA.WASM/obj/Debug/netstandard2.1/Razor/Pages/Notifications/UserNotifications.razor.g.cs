#pragma checksum "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6340d8eff18cc271b07480152eb074b441adf8a9"
// <auto-generated/>
#pragma warning disable 1591
namespace OA.WASM.Pages.Notifications
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
    public partial class UserNotifications : UserNotificationsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "notifications-list-con");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "i");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
                 NotificationListToggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "fas fa-bell not-btn");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 5 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
         if(UnSeenCount != 0){

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "not-count");
            __builder.AddContent(10, " ");
            __builder.AddContent(11, 
#nullable restore
#line 6 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
                                      UnSeenCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 7 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "notifications-list" + " " + (
#nullable restore
#line 10 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
                                    ActiveNotList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "not-list-header");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "not-list-title");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.AddContent(25, 
#nullable restore
#line 13 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
                 Localizer["New Notifications"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "not-list-controls");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
                             MarkAllAsSeen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, " ");
            __builder.AddContent(34, 
#nullable restore
#line 16 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
                                              Localizer["Mark All As Seen"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 19 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
         foreach (var not in UnSeenNotifications)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "not-item-con");
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "not-item-head");
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "not-item-title");
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.AddContent(49, 
#nullable restore
#line 24 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
                         Localizer[not.Title]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "not-item-date");
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.AddContent(55, 
#nullable restore
#line 27 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
                         TimeSpan(not.Date)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "not-item-body");
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.AddContent(62, 
#nullable restore
#line 31 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
                     Localizer[not.Body]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 34 "D:\FS\DSA\DSA_APP\OA_sln\OA.WASM\Pages\Notifications\UserNotifications.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
