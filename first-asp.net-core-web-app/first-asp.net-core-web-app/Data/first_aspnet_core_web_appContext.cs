using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using first_asp.net_core_web_app.Models;

namespace first_asp.net_core_web_app.Data
{
    public class first_aspnet_core_web_appContext : DbContext
    {
        public first_aspnet_core_web_appContext (DbContextOptions<first_aspnet_core_web_appContext> options)
            : base(options)
        {
        }

        public DbSet<first_asp.net_core_web_app.Models.Movie> Movie { get; set; } = default!;
    }
}
