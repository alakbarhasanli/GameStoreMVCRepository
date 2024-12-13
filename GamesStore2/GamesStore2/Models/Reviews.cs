namespace GamesStore2.Models
{
    public class Reviews:BaseEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public int GameId { get; set; }
        public Games? games { get; set; }
        
    }
}
