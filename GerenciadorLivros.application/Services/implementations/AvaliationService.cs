using GerenciadorLivros.application.InputModel;
using GerenciadorLivros.application.Services.interfaces;
using GerenciadorLivros.application.ViewModel;
using GerenciadorLivros.intraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.Services.implementations
{
    public class AvaliationService:IAvaliationService
    {
        private readonly GerenciadorLivrosDbContext _dbContext;
        public AvaliationService(GerenciadorLivrosDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Guid Create(NewAvaliationInputModel NewAvaliationInputModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<AvaliationViewModel> Get(string query)
        {
            throw new NotImplementedException();
        }

        public AvaliationViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(AvaliationUpdateInputModel UpdateBookModel)
        {
            throw new NotImplementedException();
        }
    }
}
