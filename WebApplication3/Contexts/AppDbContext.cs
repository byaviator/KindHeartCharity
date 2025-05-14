using Microsoft.EntityFrameworkCore;

namespace KindHeartCharity.Contexts
{
    public class AppDbContext :DbContext
    {
        private readonly string _connectionString= @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=KindHeartCharity;Trusted_Connection=True;TrustserverCertificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
