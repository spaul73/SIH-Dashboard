#pragma checksum "D:\SIH\SIH-Dashboard\SIH Dashboard\Shared\NavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c630252b72cec7b12b05fa23ad476acf6db8b4a3"
// <auto-generated/>
#pragma warning disable 1591
namespace SIH_Dashboard.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\SIH\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SIH\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SIH\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SIH\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SIH\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SIH\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SIH\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SIH\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using SIH_Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SIH\SIH-Dashboard\SIH Dashboard\_Imports.razor"
using SIH_Dashboard.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-dark black");
            __builder.AddMarkupContent(2, "\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\"#\">SIH Dashboard</a>\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(4, @"<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#basicExampleNav"" aria-controls=""basicExampleNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>

    
    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "collapse navbar-collapse black-text");
            __builder.AddAttribute(7, "id", "basicExampleNav");
            __builder.AddMarkupContent(8, "\r\n\r\n        \r\n        ");
            __builder.AddMarkupContent(9, @"<ul class=""navbar-nav mr-auto"">
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">
                    Home
                    
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">Features</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#"">Pricing</a>
            </li>

        </ul>
");
#nullable restore
#line 34 "D:\SIH\SIH-Dashboard\SIH Dashboard\Shared\NavBar.razor"
         if (GlobalUser.UID == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.AddMarkupContent(11, "<a class=\"nav-link navbar-right\" href=\"/signin\" style=\"margin-left:-10px\">Login</a>\r\n");
#nullable restore
#line 37 "D:\SIH\SIH-Dashboard\SIH Dashboard\Shared\NavBar.razor"
        }
        else if(!GlobalUser.IsVerified && NavManager.Uri.IndexOf("/verifyaccount/") <0)
        {
            NavManager.NavigateTo("/verifyaccount/" + GlobalUser.Email);
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "class", "nav-link navbar-right");
            __builder.AddAttribute(15, "href", "/userinfo");
            __builder.AddAttribute(16, "style", "margin-left:-10px");
            __builder.AddContent(17, 
#nullable restore
#line 44 "D:\SIH\SIH-Dashboard\SIH Dashboard\Shared\NavBar.razor"
                                                                                         GlobalUser.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 45 "D:\SIH\SIH-Dashboard\SIH Dashboard\Shared\NavBar.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n    \r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.AddMarkupContent(22, "<style>\r\n    body {\r\n        background-image: url(\'./images/blur.jpg\');\r\n        background-repeat: no-repeat;\r\n        background-size: 100% 100%;\r\n        background-position: 0% 0%;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Runtime { get; set; }
    }
}
#pragma warning restore 1591
