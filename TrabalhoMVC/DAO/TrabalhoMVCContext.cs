using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoMVC.Models
{
    public class TrabalhoMVCContext : DbContext
    {
        public TrabalhoMVCContext (DbContextOptions<TrabalhoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<TrabalhoMVC.Models.Filme> Filme { get; set; }
    }
}
