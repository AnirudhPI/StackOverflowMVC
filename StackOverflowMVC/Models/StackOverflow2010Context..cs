using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace StackOverflowMVC.Models
{
    public class StackOverflow2010Context : DbContext
    {
        public StackOverflow2010Context()
        {
        }

        public StackOverflow2010Context(DbContextOptions<StackOverflow2010Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Badge> Badges { get; set; }

        public virtual DbSet<Post> Posts { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Vote> Votes { get; set; }
    }
}
