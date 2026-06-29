using ImageSharing.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace ImageSharing.Client.Components
{
    public partial class Image
    {
        [Parameter]
        public ImageModel ImageModel { get; set; } = default!;
        [Parameter]
        public bool SameSize { get; set; } 
    }
}
