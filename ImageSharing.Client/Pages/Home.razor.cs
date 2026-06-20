using ImageSharing.Shared.Interfaces;
using ImageSharing.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ImageSharing.Client.Pages
{
    public partial class Home
    {
        [Inject]
        private IImageService ImageService { get; set; } = default!;
        [Inject]
        private IJSRuntime JsRuntime { get; set; } = default!;
        [PersistentState]
        public ImageModel[]? ImageModels { get; set; } 
        public ElementReference Container;
        public bool IsLoading = true;

        protected override async Task OnInitializedAsync()
        {
            ImageModels = ImageService.GetImages();
        }
 
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JsRuntime.InvokeVoidAsync("initMasonry", Container);
                IsLoading = false;
                StateHasChanged();
            }
        }
    }
}
