namespace rypermuapi.Domain.Entities
{
    public class LibrarySong
    {
        public int Id { get; set; }
        public int LibraryId { get; set; }
        public int SongId { get; set; }
        public DateTime AddedAt { get; set; }
        public string Notes { get; set; }

        // Navigation properties
        public Library Library { get; set; }
        public Song Song { get; set; }
    }
}
