namespace rypermuapi.Domain.Entities
{
    public class PlaylistSong
    {
        public int Id { get; set; }
        public int PlaylistId { get; set; }
        public int SongId { get; set; }
        public int Position { get; set; }
        public DateTime AddedAt { get; set; }

        // Navigation properties
        public Playlist Playlist { get; set; }
        public Song Song { get; set; }
    }
}
