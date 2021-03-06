#pragma checksum "C:\Ks\BlazorGrid\SisWeb\Components\Pages\ObjectDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5c8902db73ee91d1a6b8f83dc5db10469c0417"
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
    using SisWeb.Services.Dto.Sis;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/objectdetail")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/objectdetail/{UserAction}/{Id}")]
    public class ObjectDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 31 "C:\Ks\BlazorGrid\SisWeb\Components\Pages\ObjectDetail.razor"
            

    [Parameter]
    private string UserAction { get; set; }
    [Parameter]
    private string Id { get; set; }

    private ObjectModelDto Obj { get; set; }

    protected override async Task OnInitAsync()
    {
        if (!session.AuthInformation.IsAuthentized)
        {
            uriHelper.NavigateTo("/login");
            return;
        }

        Obj = objectService.GetObject(Convert.ToInt32(Id));

        base.OnInit();
    }

    void OnObjektChanged(UIChangeEventArgs changeEvent)
    {
        Obj.objekt = (string)changeEvent.Value;
    }

    void OnObjektTypeChanged(UIChangeEventArgs changeEvent)
    {
        Obj.typ = (string)changeEvent.Value;
    }

    void OnCancel()
    {
        uriHelper.NavigateTo("/object");
    }

    void OnSave()
    {
        objectService.SaveObject(Obj);
        uriHelper.NavigateTo("/object");
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SisWeb.Services.SisCore.IObjectService objectService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SisWeb.Services.Session.ISessionHelper session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
    }
}
#pragma warning restore 1591
