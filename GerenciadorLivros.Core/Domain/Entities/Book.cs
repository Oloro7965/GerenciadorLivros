using GerenciadorLivros.Domain.Enums;
using Microsoft.VisualBasic.FileIO;

namespace GerenciadorLivros.Domain.Entitites
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public string ISBN { get; private set; }

        public string Autor { get; private set; }

        public string Editor { get; private set; }
        
        public int PublishedYear { get; private set; }
        public EBookGender BookGender { get; private set; }
        public int PagesQuantity { get; set; }

        public DateTime CreatedDate { get; set; }

        public decimal TotalRating { get; set; }

        public byte BookCape { get; set; }

        public List<Avaliation> Avaliations { get; set; }

        public bool IsDeleted { get; private set; }
        public Book() { }
        public Book(string title, string description, string iSBN, string autor, string editor, int publishedYear, int pagesQuantity)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            ISBN = iSBN;
            Autor = autor;
            Editor = editor;
            PublishedYear = publishedYear;
            PagesQuantity = pagesQuantity;
            CreatedDate = DateTime.Now;
            Avaliations = new List<Avaliation>();
            IsDeleted = false;
        }
        public void Update(string description)
        {
            Description = description;
        }
        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
