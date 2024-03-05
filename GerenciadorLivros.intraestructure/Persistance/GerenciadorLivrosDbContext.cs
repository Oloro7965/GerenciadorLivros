using GerenciadorLivros.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.intraestructure.Persistance
{
    public class GerenciadorLivrosDbContext
    {
        public List<User> Users { get; set; }
        public List<Avaliation> Avaliations { get; set; }
        public List<Book> Books { get; set; }
        public GerenciadorLivrosDbContext() { 
            Users = new List<User>();
            Avaliations = new List<Avaliation>();
            Books = new List<Book>();
        } 
    }
}
