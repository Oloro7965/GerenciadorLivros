using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.InputModel
{
    public class NewUserInputModel
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public NewUserInputModel(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
