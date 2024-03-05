using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.InputModel
{
    public class BookUpdateInputModel
    {
        public Guid Id { get;private set; }
        public string Description { get; private set; }
        public BookUpdateInputModel(Guid id,string description) {
            Id = id;
            Description = description;
        }
    }
}
