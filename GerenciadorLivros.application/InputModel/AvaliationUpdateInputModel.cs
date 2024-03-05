using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.InputModel
{
    public class AvaliationUpdateInputModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public AvaliationUpdateInputModel(Guid id,string description,int rating) {
            Id= id;
            Description=description; 
            Rating=rating;
        }
    }
}
