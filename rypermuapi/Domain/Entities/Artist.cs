namespace rypermuapi.Domain.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Image { get; set; }

        // Navigation property
        public ICollection<Song> Songs { get; set; }
    }
}
