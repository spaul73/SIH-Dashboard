#pragma checksum "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\Pages\SignInPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a242b28a00869e598c92373e11f775a6526cea5"
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
#line 1 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\_Imports.razor"
using SIH_Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\_Imports.razor"
using SIH_Dashboard.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/signin")]
    public partial class SignInPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<SIH_Dashboard.Shared.NavBar>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container my-5 px-0");
            __builder.AddMarkupContent(4, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(5, "section");
            __builder.AddAttribute(6, "class", "p-5 my-md-5 text-center");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "form");
            __builder.AddAttribute(9, "class", "my-5 mx-md-5");
            __builder.AddMarkupContent(10, "\r\n\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-6 mx-auto");
            __builder.AddMarkupContent(16, "\r\n                    \r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card");
            __builder.AddMarkupContent(19, "\r\n\r\n                        \r\n                        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-body");
            __builder.AddMarkupContent(22, "\r\n\r\n                            \r\n                            ");
            __builder.OpenElement(23, "form");
            __builder.AddAttribute(24, "class", "text-center");
            __builder.AddAttribute(25, "style", "color: #757575;");
            __builder.AddMarkupContent(26, "\r\n\r\n                                ");
            __builder.AddMarkupContent(27, "<h3 class=\"font-weight-bold my-4 pb-2 text-center dark-grey-text\">Log In</h3>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\Pages\SignInPage.razor"
                                 if (ErrorMessage != null)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                                    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "alert alert-danger");
            __builder.AddAttribute(31, "role", "alert");
            __builder.AddMarkupContent(32, "\r\n                                        ");
            __builder.AddContent(33, 
#nullable restore
#line 29 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\Pages\SignInPage.razor"
                                         ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 31 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\Pages\SignInPage.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "\r\n                                \r\n                                ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "email");
            __builder.AddAttribute(39, "id", "defaultSubscriptionFormPassword");
            __builder.AddAttribute(40, "class", "form-control mb-4");
            __builder.AddAttribute(41, "placeholder", "Email");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\Pages\SignInPage.razor"
                                                                                                                                                    email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n                                \r\n                                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "password");
            __builder.AddAttribute(47, "id", "defaultSubscriptionFormEmail");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "placeholder", "Password");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\Pages\SignInPage.razor"
                                                                                                                                                  password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                ");
            __builder.OpenElement(53, "small");
            __builder.AddAttribute(54, "id", "passwordHelpBlock");
            __builder.AddAttribute(55, "class", "form-text text-right blue-text");
            __builder.AddMarkupContent(56, "\r\n                                    ");
            __builder.OpenElement(57, "p");
            __builder.AddAttribute(58, "style", "color:dodgerblue;font-weight:bold;cursor:pointer");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\Pages\SignInPage.razor"
                                                                                                          ResetPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "Recover Password");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n                                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "text-center");
            __builder.AddMarkupContent(65, "\r\n                                    ");
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "type", "button");
            __builder.AddAttribute(68, "class", "btn btn-info my-4 btn-block blue-gradient  waves-effect");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\Pages\SignInPage.razor"
                                                                                                                                    LogIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, "Log In");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                    ");
            __builder.AddMarkupContent(72, "<a href=\"/signup\"><button class=\"btn purple-gradient white-text  waves-effect\">Sign Up Instead</button></a>\r\n\r\n\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            \r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    \r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\r\n");
            __builder.AddMarkupContent(82, "<style>\r\n    body {\r\n        background-image: url(\'./images/blur.jpg\');\r\n        background-repeat: no-repeat;\r\n        background-size: 100% 100%;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\shive\Desktop\Test\SIH Dashboard\SIH Dashboard\Pages\SignInPage.razor"
 
    string ErrorMessage { get; set; }
    string email { get; set; } = "";
    string password { get; set; } = "";
    private async void LogIn()
    {
        var x = await JsRuntime.InvokeAsync<AuthResult>("signInUser", email, password);
        if (!x.status)
        {
            ErrorMessage = x.message;
            StateHasChanged();
        }
        else
        {
            GlobalUser.Email = email;
            GlobalUser.UID = x.uid;
            GlobalUser.IsVerified = x.emailVerified;
            StateHasChanged();
            if (x.emailVerified)
            {
                NavigationManager.NavigateTo("/");
            }
            else
            {
                await JsRuntime.InvokeAsync<AuthResult>("verifyEmail");
                NavigationManager.NavigateTo("verifyaccount/" + email);
            }
        }
    }
    async void ResetPassword()
    {
        var x = await JsRuntime.InvokeAsync<AuthResult>("resetPassword", email);
        if (!x.status)
            ErrorMessage = x.message;

        ErrorMessage = "An Reset email has been sent at:" + email;
        StateHasChanged();
    }

    public class AuthResult
    {
        public bool status { get; set; }
        public string message { get; set; }
        public string uid { get; set; }
        public bool emailVerified { get; set; }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591