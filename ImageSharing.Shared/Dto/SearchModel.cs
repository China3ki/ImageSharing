using ImageSharing.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace ImageSharing.Shared.Dto
{
    public class SearchModel
    {
        [Required]
        public string Query = string.Empty;
        [Required]
        public SearchBy SearchOption;
    }
}
