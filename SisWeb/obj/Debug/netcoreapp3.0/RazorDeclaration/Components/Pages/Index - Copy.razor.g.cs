#pragma checksum "C:\Ks\SisWeb\SisWeb\Components\Pages\Index - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2685c1c9b6873dfb5bfe7861c917bb51e4e28a51"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SisWeb.Components.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Services;
    using Microsoft.JSInterop;
    using SisWeb.Components.Shared;
    using Blazorise;
    using Core.EF.EntityFrameworkCore.Repositories;
    using SisWeb.EF.Models;
    using Core.Core.NetCore;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 8 "C:\Ks\SisWeb\SisWeb\Components\Pages\Index - Copy.razor"
            

    protected override async Task OnInitAsync()
    {
        if (!session.AuthInformation.IsAuthentized)
        {
            uriHelper.NavigateTo("/login");
            return;
        }


        base.OnInit();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SisWeb.Services.Authentication.IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SisWeb.Services.Session.ISessionHelper session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
    }
}
#pragma warning restore 1591
