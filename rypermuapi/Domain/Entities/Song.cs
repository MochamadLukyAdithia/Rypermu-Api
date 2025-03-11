namespace rypermuapi.Domain.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int CategoryId { get; set; }
        public string Cover { get; set; }
        public string Music { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }

        // Navigation properties
        public Artist Artist { get; set; }
        public Category Category { get; set; }
        public ICollection<LibrarySong> LibrarySongs { get; set; }
        public ICollection<PlaylistSong> PlaylistSongs { get; set; }
    }
}
