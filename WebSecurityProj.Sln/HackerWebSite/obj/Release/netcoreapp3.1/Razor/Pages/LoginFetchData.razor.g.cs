#pragma checksum "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\LoginFetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01d7261f8aaa642cc801134a5aaaf22e4d047f14"
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
#line 3 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\LoginFetchData.razor"
using HackerWebSite.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Hackedlogin_old")]
    public partial class LoginFetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Hacked Credentials</h2>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component fetches data from HackedLogins.</p>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\LoginFetchData.razor"
 if (LoginDtoList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Empty</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\LoginFetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>S.No</th>\r\n                <th>Email</th>\r\n                <th>Password</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 25 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\LoginFetchData.razor"
             foreach (var loginDto in LoginDtoList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 28 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\LoginFetchData.razor"
                         loginDto.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 29 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\LoginFetchData.razor"
                         loginDto.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 30 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\LoginFetchData.razor"
                         loginDto.Password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 32 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\LoginFetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 35 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\LoginFetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\LoginFetchData.razor"
       
    private List<LoginDTO> LoginDtoList;

    protected override async Task OnInitializedAsync()
    {
        LoginDtoList = await HackedCredentialsService.GetLoginAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HackedCredentialsService HackedCredentialsService { get; set; }
    }
}
#pragma warning restore 1591
