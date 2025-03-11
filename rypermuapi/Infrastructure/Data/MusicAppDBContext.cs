using Microsoft.EntityFrameworkCore;
using rypermuapi.Domain.Entities;
namespace rypermuapi.Infrastructure.Data
{
    public class MusicAppDBContext : DbContext
    {
        public MusicAppDbContext(DbContextOptions<MusicAppDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<LibrarySong> LibrarySongs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<PlaylistSong> PlaylistSongs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure table names to match PostgreSQL conventions
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Role>().ToTable("roles");
            modelBuilder.Entity<UserProfile>().ToTable("user_profiles");
            modelBuilder.Entity<Library>().ToTable("libraries");
            modelBuilder.Entity<Song>().ToTable("songs");
            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Artist>().ToTable("artists");
            modelBuilder.Entity<LibrarySong>().ToTable("library_songs");
            modelBuilder.Entity<Playlist>().ToTable("playlists");
            modelBuilder.Entity<PlaylistSong>().ToTable("playlist_songs");

            // Configure User entity
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("pk_users");
                entity.Property(e => e.Id).HasColumnName("id_user").UseIdentityAlwaysColumn();
                entity.Property(e => e.RoleId).HasColumnName("role");
                entity.Property(e => e.Username).HasColumnName("username").HasMaxLength(50);
                entity.Property(e => e.Password).HasColumnName("password").HasMaxLength(255);
                entity.Property(e => e.Email).HasColumnName("email").HasMaxLength(255);
                entity.Property(e => e.LastLogin).HasColumnName("last_login");
                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("fk_users_roles");
            });

            // Configure relationships for all entities
            // [Additional configuration for other entities would go here]
        }
    
}
}
