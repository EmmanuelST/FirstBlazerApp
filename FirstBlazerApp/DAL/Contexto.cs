
using FirstBlazerApp.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstBlazerApp.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Generos> Generos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .\SqlExpress; Database = RazorDb; Trusted_Connection = True; ");
        }
    }
}
