using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.ViewModel
{
    public class UserViewModel
    {
        public string Email { get; private set; }
        public string Name { get; private set; }
        public UserViewModel(string name,string email) {
            Email = email;
            Name = name;
        }
    }
}
