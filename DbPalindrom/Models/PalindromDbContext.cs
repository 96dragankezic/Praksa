using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace DbPalindrom.Models
{
    public class PalindromDbContext : DbContext
    {
        public DbSet<Palindrome> Palindromes { get; set; }
        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-U8FHNKB\\SQLEXPRESS;Database=Palindromes;Trusted_Connection=True;");
            //base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Palindrome>(pa => { pa.HasNoKey(); });
           // modelBuilder.Entity<Candidate>(pa => { pa.HasNoKey(); });
        }
    }
}
