using ImageSharing.Shared.Interfaces;
using ImageSharing.Shared.Models;

namespace ImageSharing.Tests
{
    public class TestSearchService : ISearchService
    {
        private readonly TagModel[] _tags = [];
        private readonly string[] _titles = [];
        private readonly string[] _users = [];
        public TestSearchService()
        {
            _tags = [new TagModel { Name = "Mountains", Amount = 2 }];
            _titles = ["Silence Before the Summer Storm", "Whispers in the Old Forest", "Melancholy of the Forgotten City", "Girl With a Pearl Shadow", "Light Dancing on Stormy Seas", "Cherry Blossoms in the Morning", "Abstraction in Shades of Blue", "Clocks Melting in the Sun", "Night Train to Nowhere", "Golden Autumn in the Valley"];
            _users = [ "ShadowHunter99", "PixelNinja", "CosmicWanderer", "NeonSamurai", "QuantumMechanic", "LunarEclipse", "CyberFox", "StarGazerX", "EchoChamber", "VelocityRider" ];
        }
        public TagModel[] SearchByTags(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return [];
            return _tags.Where(t => t.Name.Contains(input, StringComparison.CurrentCultureIgnoreCase)).ToArray();
        }
        public string[] SearchByUser(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return [];
            return _users.Where(t => t.Contains(input, StringComparison.CurrentCultureIgnoreCase)).ToArray();
        }
        public string[] SearchByTitle(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return [];
            return _titles.Where(t => t.Contains(input, StringComparison.CurrentCultureIgnoreCase)).ToArray();
        }
    }
}
