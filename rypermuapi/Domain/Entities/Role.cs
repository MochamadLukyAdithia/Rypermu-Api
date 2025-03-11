namespace rypermuapi.Domain.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Permission { get; set; }

        // Navigation property
        public ICollection<User> Users { get; set; }
    }
}
