namespace rypermuapi.Domain.Entities
{
    public class UserProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Profile { get; set; }
        public string Bio { get; set; }

        // Navigation property
        public User User { get; set; }
    }
}
