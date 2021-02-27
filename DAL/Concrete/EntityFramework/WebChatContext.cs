using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Concrete.EntityFramework
{
    public class WebChatContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WebChatDB;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMessage>()
                .HasKey(um => new { um.UserId, um.MessageId });
            modelBuilder.Entity<UserMessage>()
                .HasOne(um => um.user)
                .WithMany(u => u.UserMessages)
                .HasForeignKey(um => um.MessageId);
            modelBuilder.Entity<UserMessage>()
                .HasOne(um => um.message)
                .WithMany(m => m.UserMessages)
                .HasForeignKey(um => um.MessageId);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }


    }
}
