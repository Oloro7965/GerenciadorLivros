using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros.application.ViewModel
{
    public class AvaliationViewModel
    {

        public int Rating { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime StartedDate { get; set; }

        public DateTime FinishedDate { get; set; }
        public AvaliationViewModel(int rating, string description, DateTime createdDate, DateTime startedDate, DateTime finishedDate)
        {
            Rating = rating;
            Description = description;
            CreatedDate = createdDate;
            StartedDate = startedDate;
            FinishedDate = finishedDate;
        }
    }
}
