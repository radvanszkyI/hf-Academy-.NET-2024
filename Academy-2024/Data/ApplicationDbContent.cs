using Academy_2024.Models;
using Microsoft.EntityFrameworkCore;

namespace Academy_2024.Data
{
    public class ApplicationDbContent:DbContext
    {
        public readonly string _dbPath;

        public ApplicationDbContent()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            _dbPath = Path.Combine(path, "academy.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={_dbPath}");

        public DbSet<User> users { get; set; }
    }
}
