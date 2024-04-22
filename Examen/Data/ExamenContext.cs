using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamenProgreso1.Models;

namespace Examen.Data
{
    public class ExamenContext : DbContext
    {
        public ExamenContext (DbContextOptions<ExamenContext> options)
            : base(options)
        {
        }

        public DbSet<ExamenProgreso1.Models.JMora> JMora { get; set; } = default!;
    }
}
