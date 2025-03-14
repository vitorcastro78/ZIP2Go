using Microsoft.EntityFrameworkCore;
using Admin.Repository.Models;

namespace Admin.Repository.DataContext
{
    public class AdminDataContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.UseSqlite("Data Source=.\\Database\\admin.db");
        //}


        private readonly string _connectionString;

        public AdminDataContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public AdminDataContext(DbContextOptions<AdminDataContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }


        public DbSet<RequestHeaders> RequestHeaders { get; set; }
     
    }
}