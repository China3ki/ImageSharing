using ImageSharing.Shared.Dto;
using ImageSharing.Shared.Interfaces;
using ImageSharing.Shared.Models;

namespace ImageSharing.Client.Services
{
    public class SearchService(HttpClient httpClient) : ISearchService
    {
        public SearchModel SearchModel { get; set; } = new();
        private HttpClient _httpClient = httpClient;
        public TagModel[] SearchByTags(string input)
        {
            throw new NotImplementedException();
        }
        public string[] SearchByUser(string input)
        {
            throw new NotImplementedException();
        }
        public string[] SearchByTitle(string input)
        {
            throw new NotImplementedException();
        }
    }
}
