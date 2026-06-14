namespace ImageSharing.Shared.Models
{
    public class SearchModel
    {
        public TagModel[] Tags { get; set; } = [];
        public string[] Titles { get; set; } = [];
        public string[] Users { get; set; } = [];
    }
}
