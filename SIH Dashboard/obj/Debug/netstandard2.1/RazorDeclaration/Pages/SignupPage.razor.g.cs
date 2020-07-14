#pragma checksum "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\Pages\SignupPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fa724411553f8d553f983fb7078d79dd9332010"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 5 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\Pages\SignupPage.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class SignupPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\shive\Desktop\Test\SIH-Dashboard\SIH Dashboard\Pages\SignupPage.razor"
 
    string ErrorMessage { get; set; }
    string email { get; set; } = "";
    string password { get; set; } = "";
    public string Name { get; set; } = "";
    public string Role { get; set; } = "";
    public string phoneNumber { get; set; } = "";
    private async void SignUp()
    {
        if (IsAllValid())
        {

            var x = await JsRuntime.InvokeAsync<SignInPage.AuthResult>("signUpUser", email, password);
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

                SaveUserData();

                if (x.emailVerified)
                {
                    NavigationManager.NavigateTo("/");
                }
                else
                {
                    await JsRuntime.InvokeAsync<SignInPage.AuthResult>("verifyEmail");
                    NavigationManager.NavigateTo("verifyaccount/" + email);
                }
            }
        }
    }

    private bool IsAllValid()
    {
        if (!IsValidEmail(email))
        {
            ErrorMessage = "Invalid Email.";
            return false;
        }
        else if (Name.Length < 3)
        {
            ErrorMessage = "Name too short.";
            return false;
        }
        else if(Role.Length<=0 || Enum.GetNames(typeof(Roles)).ToList().IndexOf(Role)<0)
        {
            ErrorMessage = "Role Selected is not valid.";
            return false;
        }
        else if (phoneNumber.Length != 10 && !string.IsNullOrWhiteSpace(phoneNumber))
        {
            ErrorMessage = "Invalid Phone Number.";
            return false;
        }
        else
        {
            return true;
        }
    }
    public static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z",RegexOptions.IgnoreCase)
            && Regex.IsMatch(email, @"^(?=.{1,64}@.{4,64}$)(?=.{6,100}$).*");
    }

    private void SaveUserData()
    {
        DatabaseHelper.WriteData(JsRuntime, "Users/" + GlobalUser.UID, new UserData()
        {
            Email = email,
            Name = Name,
            Role = (Roles)Enum.Parse(typeof(Roles),Role,true),
            Phone = long.Parse(phoneNumber)
        });
    }
    private void SigninClick()
    {
        NavigationManager.NavigateTo("/signin");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
