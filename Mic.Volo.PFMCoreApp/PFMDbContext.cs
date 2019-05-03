using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mic.Volo.PFMCoreApp
{
    public class PFMDbContext : DbContext
    {
        public DbSet<Wallet> Wallets { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=PFM_EFCore;Integrated Security=True");
        }
    }

    public class Wallet
    {
        public int WalletId { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public DateTime Timestamp { get; set; }

        public string Comment { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<Wallet> Wallets { get; set; }
    }
}
