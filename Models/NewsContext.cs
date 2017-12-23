using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Models
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options)
            : base(options)
        {

        }

        public DbSet<News> News { get; set; }

        public DbSet<Users> Users { get; set; }

    }
}