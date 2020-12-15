using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace FlappyBird
{
    public class ScoreContext: DbContext
    {
        public DbSet<Score> Scores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SVYATKO228;Database=FlappyBird;Trusted_Connection=True;");
        }

    }
}
