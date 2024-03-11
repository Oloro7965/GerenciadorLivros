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
    public class UserService : IUserService
    {
        private readonly GerenciadorLivrosDbContext _dbContext;
        public  UserService(GerenciadorLivrosDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Guid Create(NewUserInputModel UserInputModel)
        {
            var user = new User(UserInputModel.Email, UserInputModel.Name);
            _dbContext.Users.Add(user);
            return user.Id;
        }
        //public Guid CreateAvaliation(NewAvaliationInputModel AvaliationInputModel)
        //{
            //var avaliation= new Avaliation(AvaliationInputModel)
        //}
        public void Delete(Guid id)
        {
            var user=_dbContext.Users.FirstOrDefault(x => x.Id == id);
            user.Delete();
        }

        public List<UserViewModel> Get(string query)
        {
            var users = _dbContext.Users.Where(u => u.IsDeleted.Equals(false));
            var usersViewModel = users.Select(b => new UserViewModel(b.Name 
                ,b.Email))
                .ToList();
            return usersViewModel;
        }

        public UserViewModel GetById(Guid id)
        {
            var user = _dbContext.Users.FirstOrDefault(b => b.Id == id);
            var userDetailViewModel = new UserViewModel(user.Email, user.Name);
            return userDetailViewModel;
        }
    }
}
