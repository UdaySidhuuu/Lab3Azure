using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Agile_App.Models;

namespace MVC_Agile_App.Data
{
    public class MVC_Agile_AppContext : DbContext
    {
        public MVC_Agile_AppContext (DbContextOptions<MVC_Agile_AppContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Agile_App.Models.Movie> Movie { get; set; } = default!;
    }
}
