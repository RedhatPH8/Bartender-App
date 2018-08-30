using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BartendBuddy.Models
{
    public class BartendBuddyContext : DbContext
    {
        public BartendBuddyContext (DbContextOptions<BartendBuddyContext> options)
            : base(options)
        {
        }

        public DbSet<BartendBuddy.Models.Order> Orders { get; set; }
    }
}
