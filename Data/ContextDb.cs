using System;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options) { }

        DbSet<PostagemModel> Postagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostagemModel>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<PostagemModel>()
                .Property(p => p.Title)
                .IsRequired()
                .HasColumnType("varchar(200)");

            modelBuilder.Entity<PostagemModel>()
                .Property(p => p.Body)
                .IsRequired()
                .HasColumnType("text");

            modelBuilder.Entity<PostagemModel>()
                .Property(p => p.Created)
                .IsRequired()
                .HasColumnType("datetime");

            modelBuilder.Entity<PostagemModel>()
                .Property(p => p.Active)
                .IsRequired()
                .HasColumnType("boolean");

            modelBuilder.Entity<PostagemModel>()
                .ToTable("Postagens");

            base.OnModelCreating(modelBuilder);


        }
    }
}
