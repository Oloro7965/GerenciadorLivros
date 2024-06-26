﻿using GerenciadorLivros.application.InputModel;
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
        Guid CreateAvaliation(Guid BookId,NewAvaliationInputModel AvaliationInputModel);
        void Update(BookUpdateInputModel UpdateBookModel);
        Guid UpdateAvaliation(Guid BookId, AvaliationUpdateInputModel Model);
        void Delete(Guid id);
    }
}
