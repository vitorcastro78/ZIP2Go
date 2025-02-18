using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ZIP2GO.Repository.Models;

namespace Repository.DataContext
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString;

        public DataContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Account> Accounts { get; set; }
        //other models
        //with YourName if you have for example Book Model then it could be something like this:
        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
