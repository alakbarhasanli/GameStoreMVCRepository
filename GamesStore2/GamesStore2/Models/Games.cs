using System.ComponentModel.DataAnnotations.Schema;

namespace GamesStore2.Models
{
    public class Games
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price {  get; set; }
        public string? GameImageUrl { get; set; }
        public string GameId { get; set; }
        [NotMapped]
        public IFormFile? GamesPhoto { get; set; }


    }
}
