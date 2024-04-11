using GerenciadorLivros.Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.intraestructure.Persistance
{
    public class GerenciadorLivrosDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Avaliation> Avaliations { get; set; }
        public DbSet<Book> Books { get; set; }
        public GerenciadorLivrosDbContext(DbContextOptions<GerenciadorLivrosDbContext> options):base(options) 
        { 
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
    }
}
