using GerenciadorLivros.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.ViewModel
{
    public class BookViewModel
    {
        public BookViewModel(string title, string description, string iSBN, string autor, string editor, int publishedYear, int pagesQuantity,List<Avaliation> avaliations,decimal totalRating)
        {
            Title = title;
            Description = description;
            ISBN = iSBN;
            Autor = autor;
            Editor = editor;
            PublishedYear = publishedYear;
            PagesQuantity = pagesQuantity;
            Avaliations = avaliations;
            TotalRating = totalRating;
        }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public string ISBN { get; private set; }

        public string Autor { get; private set; }

        public string Editor { get; private set; }

        public int PublishedYear { get; private set; }
        public int PagesQuantity { get; private set; }
        public List<Avaliation> Avaliations { get; private set; }
        public decimal TotalRating { get; private set; }
    }
}
