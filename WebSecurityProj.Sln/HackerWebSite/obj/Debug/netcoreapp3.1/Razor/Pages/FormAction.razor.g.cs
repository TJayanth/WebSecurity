#pragma checksum "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\FormAction.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c46430551f105bb58a67d401ba0ce052f887e851"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/formaction")]
    public partial class FormAction : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Form Action Hijack</h2>\r\n");
            __builder.AddMarkupContent(1, @"<p>
    Form action hijacking allows an attacker to specify the action URL of a form via a paramter. An attacker can construct a URL that will modify the action URL of a form to point to the attacker's server.
</p>
<hr>

<img src=""/Images/formaction.png"">

<hr>
");
            __builder.AddMarkupContent(2, @"<div class=""row form-horizontal"">
    <div class=""col"">
        <div>
            <h5>Un-Secured Site</h5>
            Get Latest offers for your bank account.
            <a href=""http://www.banksite.com:84/Account/Login?url=http://www.hackersden.com:86/account/login"" target=""_blank"">
                Login
            </a>
            to avail the offer
        </div>
    </div>
    <div class=""col"">
        <div>
            <h5>Secured Site</h5>
            Get Latest offers for your bank account.
            <a href=""http://www.securedbanksite.com:85/Account/Login?url=http://www.hackersden.com:86/account/login"" target=""_blank"">
                Login
            </a>
            to avail the offer
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
