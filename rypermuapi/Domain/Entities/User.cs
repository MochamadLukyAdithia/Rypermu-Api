namespace rypermuapi.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
        public UserStatus Status { get; set; }

     
        public Role Role { get; set; }
        public UserProfile Profile { get; set; }
        public ICollection<Library> Libraries { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
        public enum UserStatus
        {
            Active,
            Inactive,
            Suspended
        }
    }
}
