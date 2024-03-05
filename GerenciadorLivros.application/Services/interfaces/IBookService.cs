using GerenciadorLivros.application.InputModel;
using GerenciadorLivros.application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.Services.interfaces
{
    public interface IBookService
    {
        List<BookViewModel> Get(string query);
        BookViewModel GetById(Guid id);
        Guid Create(NewBookInputModel BookInputModel);
        void Update(BookUpdateInputModel UpdateBookModel);
        void Delete(Guid id);

    }
}
