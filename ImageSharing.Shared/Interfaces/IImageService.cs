using ImageSharing.Shared.Models;

namespace ImageSharing.Shared.Interfaces
{
    public interface IImageService
    {
        ImageModel[] GetImages();
    }
}
