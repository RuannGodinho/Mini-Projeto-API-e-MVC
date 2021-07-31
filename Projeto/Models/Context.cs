using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto.Models
{
    public class Context : DbContext
    {
        
            public Context()
                : base()
        {
        }
                
        public DbSet<Produtos> Produto { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Projeto;Integrated Security=True");
        }
    }
}
