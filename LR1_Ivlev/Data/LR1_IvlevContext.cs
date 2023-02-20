using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LR1_Ivlev.Models;

namespace LR1_Ivlev.Data
{
    public class LR1_IvlevContext : DbContext
    {
        public LR1_IvlevContext (DbContextOptions<LR1_IvlevContext> options)
            : base(options)
        {
        }

        public DbSet<LR1_Ivlev.Models.Movie> Movie { get; set; } = default!;
    }
}
