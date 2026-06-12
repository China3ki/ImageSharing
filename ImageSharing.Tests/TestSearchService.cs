using ImageSharing.Shared.Interfaces;
using ImageSharing.Shared.Models;

namespace ImageSharing.Client.Test
{
    public class TestSearchService : ISearchService
    {
        private readonly TagModel[] _tags = [];
        private readonly string[] _titles = [];
        private readonly string[] _users = [];
        public TestSearchService()
        {
            string[] tagName = ["Mountains", "Anime", "Technology", "House", "Las Vegas", "Nature", "Forest", "People", "Boy", "Girl"];
            string[] titles = ["Silence Before the Summer Storm", "Whispers in the Old Forest", "Melancholy of the Forgotten City", "Girl With a Pearl Shadow", "Light Dancing on Stormy Seas", "Cherry Blossoms in the Morning", "Abstraction in Shades of Blue", "Clocks Melting in the Sun", "Night Train to Nowhere", "Golden Autumn in the Valley"];
            string[] users = { "ShadowHunter99", "PixelNinja", "CosmicWanderer", "NeonSamurai", "QuantumMechanic", "LunarEclipse", "CyberFox", "StarGazerX", "EchoChamber", "VelocityRider" };
            _tags = Enumerable.Range(1, 5).Select(_ => new TagModel
            {
                Name = tagName[Random.Shared.Next(0, tagName.Length)],
                Amount = Random.Shared.Next(1, 100)
            }).ToArray();
            _titles = Enumerable.Range(1, 5).Select(i => _titles[i] = titles[Random.Shared.Next(0, _titles.Length)]).ToArray();
            _users = Enumerable.Range(1, 5).Select(i => _users[i] = users[Random.Shared.Next(0, _users.Length)]).ToArray();
        }
        public TagModel[] SearchByTags(string input) => _tags.Where(t => t.Name.Contains(input, StringComparison.CurrentCultureIgnoreCase)).ToArray();
        public string[] SearchByUser(string input) => _users.Where(t => t.Contains(input, StringComparison.CurrentCultureIgnoreCase)).ToArray();
        public string[] SearchByTitle(string input) => _titles.Where(t => t.Contains(input, StringComparison.CurrentCultureIgnoreCase)).ToArray();
    }
}
