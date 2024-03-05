using GerenciadorLivros.application.InputModel;
using GerenciadorLivros.application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.Services.interfaces
{
    public interface IAvaliationService
    {
        List<AvaliationViewModel> Get(string query);
        AvaliationViewModel GetById(Guid id);
        Guid Create(NewAvaliationInputModel AvaliationInputModel);
        void Update(AvaliationUpdateInputModel AvaliationUpdateInputModel);
        void Delete(Guid id);
    }
}
