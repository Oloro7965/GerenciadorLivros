using GerenciadorLivros.application.InputModel;
using GerenciadorLivros.application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.Services.interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get(string query);
        UserViewModel GetById(Guid id);
        Guid Create(NewUserInputModel UserInputModel);
        //Guid CreateAvaliation(NewAvaliationInputModel AvaliationInputModel);
        void Delete(Guid id);
    }
}
