#pragma checksum "C:\Users\Jayanth\Source\Repos\WebSecurityProj.Sln\HackerWebSite\Pages\XSS.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd7e8609f9140b8e60c7e120a5087640f81a714e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
