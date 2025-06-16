using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AulaApiDevOpsManhaPiaget.Models;

namespace AulaApiDevOpsManhaPiaget.Data
{
    public class AulaApiDevOpsManhaPiagetContext : DbContext
    {
        public AulaApiDevOpsManhaPiagetContext (DbContextOptions<AulaApiDevOpsManhaPiagetContext> options)
            : base(options)
        {
        }

        public DbSet<AulaApiDevOpsManhaPiaget.Models.Produtos> Produtos { get; set; } = default!;
        public DbSet<AulaApiDevOpsManhaPiaget.Models.Fornecedor> Fornecedor { get; set; } = default!;
    }
}
