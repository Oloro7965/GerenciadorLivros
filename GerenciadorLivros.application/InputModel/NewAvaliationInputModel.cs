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
        public Guid BookId { get; private set; }

        public DateTime StartedDate { get; set; }

        public DateTime FinishedDate { get; set; }

        public NewAvaliationInputModel(int rating, string description, Guid userId, Guid bookId)
        {
            Rating = rating;
            Description = description;
            UserId = userId;
            BookId = bookId;
        }
    }
}
