using GerenciadorLivros.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.InputModel
{
    public class NewBookInputModel
    {
        public NewBookInputModel(string title, string description, string iSBN, string autor, string editor, int publishedYear, int pagesQuantity,EBookGender bookgender)
        {
            Title = title;
            Description = description;
            ISBN = iSBN;
            Autor = autor;
            Editor = editor;
            PublishedYear = publishedYear;
            this.pagesQuantity = pagesQuantity;
            BookGender = bookgender;
        }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public string ISBN { get; private set; }

        public string Autor { get; private set; }

        public string Editor { get; private set; }

        public int PublishedYear { get; private set; }
        public int pagesQuantity { get; private set; }
        public EBookGender BookGender { get; private set; }
    }
}
