using ImageSharing.Shared.Dto;
using ImageSharing.Shared.Models;
using ImageSharing.Shared.Enums;
using ImageSharing.Shared.Interfaces;
using Microsoft.AspNetCore.Components;

namespace ImageSharing.Client.Components
{
    public partial class Header
    {
        [Inject]
        private  ISearchService SearchService { get; set; } = default!;
        private readonly SearchDto _searchDto = new();
        private readonly SearchModel _searchModel = new();
        private bool _hideResults = true;
        private void ShowResults() => _hideResults = false;
        private void HideResults() => _hideResults = true;
        private void Search()
        {
            switch(_searchDto.SearchBy)
            {
                case SearchBy.Tags:
                    _searchModel.Tags = SearchService.SearchByTags(_searchDto.Query);
                    break;
                case SearchBy.Title:
                    _searchModel.Titles = SearchService.SearchByTitle(_searchDto.Query);
                    break;
                case SearchBy.User:
                    _searchModel.Users = SearchService.SearchByUser(_searchDto.Query);
                    break;

            }
        }
    }
}
