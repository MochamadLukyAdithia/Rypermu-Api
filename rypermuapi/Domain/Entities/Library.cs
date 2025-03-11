namespace rypermuapi.Domain.Entities
{
    public class Library
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<LibrarySong> LibrarySongs { get; set; }
    }
}
