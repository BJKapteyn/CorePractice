using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CorePractice.Models
{
    public class CorePracticeContext : DbContext
    {
        public CorePracticeContext (DbContextOptions<CorePracticeContext> options)
            : base(options)
        {
        }

        public DbSet<CorePractice.Models.Movie> Movie { get; set; }
    }
}
