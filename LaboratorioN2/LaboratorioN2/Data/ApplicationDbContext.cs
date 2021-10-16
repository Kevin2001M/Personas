using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LaboratorioN2.Dominio;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioN2.Data
{
    public class ApplicationDbContext : DbContext
    { 
        
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                 : base(options)
            {

            }

            public DbSet<persona> Students { get; set; }
        }
    
}
