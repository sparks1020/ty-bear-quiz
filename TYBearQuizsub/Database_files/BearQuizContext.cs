using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TYBearQuiz.Database_files
{
    public class BearQuizContext : DbContext
    {
        public DbSet<Beanie> Beanies { get; set; }

        public BearQuizContext()
        {
            Database.SetInitializer<BearQuizContext>(null);
        }
    }

}
