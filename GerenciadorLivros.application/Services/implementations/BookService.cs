using GerenciadorLivros.application.InputModel;
using GerenciadorLivros.application.Services.interfaces;
using GerenciadorLivros.application.ViewModel;
using GerenciadorLivros.Domain.Entitites;
using GerenciadorLivros.intraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.Services.implementations
{
    public class BookService : IBookService
    {
        private readonly GerenciadorLivrosDbContext _dbContext;
        public BookService(GerenciadorLivrosDbContext dbContext) {
            _dbContext = dbContext;
        }
        public Guid Create(NewBookInputModel BookInputModel)
        {
            var book = new Book(BookInputModel.Title,BookInputModel.Description,
                BookInputModel.ISBN,BookInputModel.Autor,
                BookInputModel.Editor,BookInputModel.PublishedYear,BookInputModel.pagesQuantity);
            _dbContext.Books.Add(book);
            return book.Id;
        }
        public Guid CreateAvaliation(Guid BookId, NewAvaliationInputModel AvaliationInputModel)
        {
            var avaliation = new Avaliation(AvaliationInputModel.Rating, AvaliationInputModel.Description,
                AvaliationInputModel.UserId,BookId,AvaliationInputModel.StartedDate,AvaliationInputModel.FinishedDate);
            var book = _dbContext.Books.SingleOrDefault(b=>b.Id==BookId);
            book.CreateAvaliation(avaliation.Rating,avaliation.Description,avaliation.UserId,avaliation.StartedDate,avaliation.FinishedDate);
            return avaliation.Id;
        }
        public void Delete(Guid id)
        {
            var book= _dbContext.Books.FirstOrDefault(x => x.Id==id);
            if (book!=null)
            {
                
            }
            book.Delete();
        }

        public List<BookViewModel> Get(string query)
        {
            var books = _dbContext.Books.Where(b=>b.IsDeleted==false);
            var bookViewModel = books.Select(b => new BookViewModel(b.Title,b.Description,b.ISBN,b.Autor,b.Editor,b.PublishedYear,b.PagesQuantity,b.Avaliations,b.TotalRating))
                .ToList();
            return bookViewModel;
        }

        public BookViewModel GetById(Guid id)
        {
            var book = _dbContext.Books.FirstOrDefault(b=>b.Id==id);
            var bookDetailViewModel = new BookViewModel(book.Title, book.Description, book.ISBN,
                book.Autor, book.Editor, book.PublishedYear
                , book.PagesQuantity,book.Avaliations,book.TotalRating);
            return bookDetailViewModel;
        }

        public void Update(BookUpdateInputModel UpdateBookModel)
        {
           var book=_dbContext.Books.FirstOrDefault(b=>b.Id==UpdateBookModel.Id);
           book.Update(UpdateBookModel.Description);
        }
    }
}
