using Microsoft.EntityFrameworkCore;
using MyWallWebAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWallWebAPI
{
    public class MySQLContext : DbContext {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {
        }
        //Entidade Post com nome da variavel de Post
        public DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Post>();
        }
    }
}