using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CyrelaWebMvc.Models;

namespace CyrelaWebMvc.Data
{
    public class CyrelaWebMvcContext : DbContext
    {
        public CyrelaWebMvcContext (DbContextOptions<CyrelaWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor>Vendedor { get; set; }
        public DbSet<RegistroDeVenda> RegistroDeVenda { get; set; }
    }
}
