using ImageSharing.Shared.Models;

namespace ImageSharing.Shared.Interfaces
{
    public interface ISearchService
    {
        TagModel[] SearchByTags(string input);
        string[] SearchByUser(string input);
        string[] SearchByTitle(string input);
    }
}
