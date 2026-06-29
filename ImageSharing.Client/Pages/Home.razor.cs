using ImageSharing.Shared.Interfaces;
using ImageSharing.Shared.Models;
using Microsoft.AspNetCore.Components;
namespace ImageSharing.Client.Pages
{
    public partial class Home
    {
        [Inject]
        private IImageService ImageService { get; set; } = default!;
        [Inject]
        private ICategoriesService CategoriesService { get; set; } = default!;
  
        public ImageModel[]? ImageModels { get; set; } 
        public CategoryModel[]? CategoriesModels { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ImageModels = ImageService.GetImages();
            CategoriesModels = CategoriesService.GetCategories();
        }
 
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
            }
        }
    }
}
