using ApplicationModels.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Application.Migrations.Migrations
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
        }
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        //optionsBuilber.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection"))

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ApplicationDatabase;Integrated Security=true;");
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
