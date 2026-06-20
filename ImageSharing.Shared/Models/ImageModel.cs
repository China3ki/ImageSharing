namespace ImageSharing.Shared.Models
{
    public class ImageModel
    {
        public int AuthorId { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int ImageId { get; set; }
    }
}
