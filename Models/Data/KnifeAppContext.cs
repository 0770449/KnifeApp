using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KnifeApp.Models;

namespace KnifeApp.Models.Data
{
    public class KnifeAppContext : DbContext
    {
        public KnifeAppContext(DbContextOptions<KnifeAppContext> options)
           : base(options)
    {
    }

    public DbSet<Knife> Knife { get; set; }
}
}