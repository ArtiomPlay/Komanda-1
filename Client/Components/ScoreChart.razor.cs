﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Projektas.Client.Components
{
    public partial class ScoreChart
    {
        [Parameter] public string ChartId { get; set; }
        [Parameter] public string ChartType { get; set; } = "line";
        [Parameter] public string[] Labels { get; set; }
        [Parameter] public Dataset[] Datasets { get; set; }
        [Inject] IJSRuntime JSRuntime { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("createChart", ChartId, ChartType, Labels, Datasets);
            }
        }
    }
}