using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.InputModel
{
    public class NewAvaliationInputModel
    {
        public int Rating { get; private set; }
        public string Description { get; private set; }

        public Guid UserId { get; private set; }

        public DateTime? StartedDate { get; private set; }

        public DateTime? FinishedDate { get; private set; }

        public NewAvaliationInputModel(int rating, string description, Guid userId)
        {
            Rating = rating;
            Description = description;
            UserId = userId;
        }
    }
}
