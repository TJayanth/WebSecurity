#pragma checksum "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de593bd7e30967fc0df25cd97adc3f95735310a4"
// <auto-generated/>
#pragma warning disable 1591
namespace HackerWebSite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\_Imports.razor"
using HackerWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\_Imports.razor"
using HackerWebSite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\Login.razor"
using HackerWebSite.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\Login.razor"
                 loginDTO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\Login.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<label for=\"Email\">Email Address</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "id", "Email");
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\Login.razor"
                                                                loginDTO.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginDTO.Email = __value, loginDTO.Email))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginDTO.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.AddMarkupContent(21, "<label for=\"Password\">Message</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "type", "password");
                __builder2.AddAttribute(24, "id", "Password");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\Login.razor"
                                                                                   loginDTO.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginDTO.Password = __value, loginDTO.Password))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginDTO.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.AddMarkupContent(31, "<button class=\"btn btn-primary\" type=\"submit\">Submit</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\Login.razor"
       
    private LoginDTO loginDTO = new LoginDTO();


   // protected async override void OnInitializedAsync()
   // {
     //   await HackedCredentialsService.PostLoginAsync(loginDTO.Email, loginDTO.Password);
    //}

    private async void HandleValidSubmit()
    {
        try
        {
            await HackedCredentialsService.PostLoginAsync(loginDTO.Email, loginDTO.Password);
        }
        catch
        {
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HackedCredentialsService HackedCredentialsService { get; set; }
    }
}
#pragma warning restore 1591
