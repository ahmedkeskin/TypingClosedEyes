using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TypingClosedEyes.DataAccess.EntityFramework.Mapping;
using TypingClosedEyes.Entities.Abstract;
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
            //modelBuilder.Entity<CategoryBase>().HasKey(p => p.EntityId);
            //modelBuilder.Entity<WordBase>().HasKey(p => p.EntityId);
            //modelBuilder.Entity<LevelBase>().HasKey(p => p.EntityId);
            //modelBuilder.Entity<GrammarBase>().HasKey(p => p.EntityId);
            //modelBuilder.Entity<Word>().HasBaseType<WordBase>();
            //modelBuilder.Entity<Category>().HasBaseType<CategoryBase>();
            //modelBuilder.Entity<Level>().HasBaseType<LevelBase>();
            //modelBuilder.Entity<Grammar>().HasBaseType<GrammarBase>();

            
            // Concrete maps
            modelBuilder.ApplyConfiguration(new WordMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new A1LevelMap());
            modelBuilder.ApplyConfiguration(new A2LevelMap());
            modelBuilder.ApplyConfiguration(new B1LevelMap());
            modelBuilder.ApplyConfiguration(new B2LevelMap());
            modelBuilder.ApplyConfiguration(new C1LevelMap());
            modelBuilder.ApplyConfiguration(new C2LevelMap());
            modelBuilder.ApplyConfiguration(new GrammarMap());
            
            // Base maps
            modelBuilder.ApplyConfiguration(new WordBaseMap());
            modelBuilder.ApplyConfiguration(new CategoryBaseMap());
            modelBuilder.ApplyConfiguration(new LevelBaseMap());
            modelBuilder.ApplyConfiguration(new GrammarBaseMap());

            //modelBuilder.Entity<Word>().HasKey(c => c.EntityId);
            //modelBuilder.Entity<Word>().Property(p => p.EntityId).ValueGeneratedOnAdd();
            //modelBuilder.Entity<Word>().ToTable("Words");

        }

    }
}
