#pragma checksum "C:\Ks\BlazorGrid\SisWeb\Components\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1933ba2c32bd573c4789da5d10c9af4b523f125a"
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
    using SisWeb.Services;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 38 "C:\Ks\BlazorGrid\SisWeb\Components\Pages\FetchData.razor"
            
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
