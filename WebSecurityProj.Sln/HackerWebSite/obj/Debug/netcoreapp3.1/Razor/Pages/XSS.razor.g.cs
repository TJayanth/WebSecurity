#pragma checksum "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\XSS.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd7e8609f9140b8e60c7e120a5087640f81a714e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/XSS")]
    public partial class XSS : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Cross-site scripting (XSS) Attack</h2>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>Script injection</h4>\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(2, "<p>\r\n    <img src=\"/Images/xss.png\" width=\"500px\" height=\"300px\">\r\n</p>\r\n\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(3, @"<div class=""row form-horizontal"">
    <div class=""col"">
        <div>
            <h5>Un-Secured Site</h5>
            Stealing user information without their knowledge
            <a href=""http://www.banksite.com:84/Product/ProductListing"">View Product Listing</a>
        </div>
    </div>
    <div class=""col"">
        <div>
            <h5>Secured Site</h5>
            Secured website will not allow XSS attack to be performed
            <a href=""http://www.securedbanksite.com:85/Product/ProductListing"">View Product Listing</a>
        </div>
    </div>
</div>

<hr>
");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-sm btn-outline-secondary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\XSS.razor"
                                                                   ShowDevelopersDiv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Prevention");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n<br>\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", (
#nullable restore
#line 41 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\XSS.razor"
             sqlmapDiv

#line default
#line hidden
#nullable disable
            ) + " row");
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.AddMarkupContent(20, @"<div class=""col"">
        <h4>Prevention Techniques</h4>
        <ol>
            <li>Escaping: Escaping the input. By escaping user input, key characters in the data received by a web page will be prevented from being interpreted in any malicious way.</li>
            <li>Validating Input</li>
            <li>Sanitizing: Checking if the data is actually having a potentially dangerous code like html execution</li>

        </ol>
    </div>
");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(22, "<style>\r\n    .divVisible {\r\n        display: block;\r\n    }\r\n\r\n    .divHidden {\r\n        display: none;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\XSS.razor"
            
    string sqlmapDiv { get; set; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\XSS.razor"
       
    private void ShowDevelopersDiv()
    {
        if (sqlmapDiv == "divVisible")
            sqlmapDiv = "divHidden";
        else
            sqlmapDiv = "divVisible";
    }

    protected override async Task OnInitializedAsync()
    {
        sqlmapDiv = "divHidden";

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
