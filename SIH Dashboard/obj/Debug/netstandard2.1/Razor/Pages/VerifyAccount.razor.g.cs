#pragma checksum "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\Pages\VerifyAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1086b64b0a8576b1d6fd07083efd5dc040e0f752"
// <auto-generated/>
#pragma warning disable 1591
namespace SIH_Dashboard.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using SIH_Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using SIH_Dashboard.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/verifyaccount/{text}")]
    public partial class VerifyAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<SIH_Dashboard.Shared.NavBar>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card align-items-center flex-center");
            __builder.AddMarkupContent(4, "\r\n\r\n    \r\n    \r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(8, "<h4 class=\"card-title\"><a>Verify your email</a></h4>\r\n        \r\n        ");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "class", "card-text");
            __builder.AddMarkupContent(11, "\r\n            Email has been sent to ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "style", "color:dodgerblue");
            __builder.OpenElement(14, "b");
            __builder.AddContent(15, 
#nullable restore
#line 17 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\Pages\VerifyAccount.razor"
                                                                      Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, " kindly verify your email\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        \r\n        ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\Pages\VerifyAccount.razor"
                          VerifyEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddContent(21, "Resend email");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 21 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\Pages\VerifyAccount.razor"
         if (error != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "alert alert-danger");
            __builder.AddAttribute(26, "role", "alert");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddContent(28, 
#nullable restore
#line 24 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\Pages\VerifyAccount.razor"
                  error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 26 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\Pages\VerifyAccount.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(34, "<style>\r\n    body {\r\n        background-image: url(\'./images/blur.jpg\');\r\n        background-repeat: no-repeat;\r\n        background-size: 100% 100vh;\r\n        background-position: 0% 0%;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\Pages\VerifyAccount.razor"
 
    [Parameter]
    public string Text { get; set; }
    private string error { get; set; }
    private async void VerifyEmail()
    {
        await Runtime.InvokeAsync<SignInPage.AuthResult>("verifyEmail");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Runtime { get; set; }
    }
}
#pragma warning restore 1591
