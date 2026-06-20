using ImageSharing.Shared.Interfaces;
using ImageSharing.Shared.Models;

namespace ImageSharing.Tests
{
    public class TestImageService : IImageService
    {
        private readonly ImageModel[] _imageModel = [];
        public TestImageService()
        {
            _imageModel = [
                new ImageModel { Author = "Johny Doe", Image = "https://preview.redd.it/mt-hood-4-5-v0-jcvt63iwpate1.jpg?width=640&crop=smart&auto=webp&s=e519bdf7678d94433f58e04a43ce5c90fae25d8a" },
                new ImageModel { Author = "Chinaski", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTarlwKev6pa-dI85_nBT-_-tWzAZGQXzfjl2Ui4srADlO0n89AMqy8nGPV&s=10"},
                new ImageModel {Author = "Katrina", Image = "https://gamesboard.pl/wp-content/uploads/2025/11/wiedzmin444-scaled.webp"},
                new ImageModel {Author = "Billie", Image = "https://m.media-amazon.com/images/I/71UeipBivfL._AC_UF894,1000_QL80_.jpg"},
                new ImageModel { Author = "Ciri", Image = "https://i.pinimg.com/736x/19/6d/18/196d18bcde7d5edb043b3f42193b1b7e.jpg"},
                new ImageModel { Author = "V", Image = "https://images.squarespace-cdn.com/content/v1/5784e6021b631b042073fcee/1479385461280-J0G09KBCD2AWKXY58BKZ/DSC_2217Iwm.JPG"},
                new ImageModel { Author = "Spdier", Image = "https://fwcdn.pl/fpo/96/95/9695/7518091_1.3.jpg"}
            ];
        }
        public ImageModel[] GetImages()
        {
            return _imageModel;
        }
    }
}
