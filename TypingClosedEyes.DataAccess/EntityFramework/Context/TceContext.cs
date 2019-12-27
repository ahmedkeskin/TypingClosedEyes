using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.Entities.Concrete;

namespace TypingClosedEyes.DataAccess.EntityFramework.Context
{
    public class TceContext : DbContext
    {
        public DbSet<Word> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite(@"Data Source=Tce.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Word>().HasKey(c => c.EntityId);
            modelBuilder.Entity<Word>().ToTable("Words");
        }
        
    }
}
