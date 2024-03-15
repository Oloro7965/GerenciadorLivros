namespace GerenciadorLivros.Domain.Entitites
{
    public class Avaliation
    {
        public Guid Id { get;private set; }

        public int Rating { get; private set; }

        public string Description { get;private set; }

        public Guid UserId { get; private set; }

        public Guid BookId { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public DateTime StartedDate { get;private set; }

        public DateTime FinishedDate { get;private set; }

        public Avaliation() { }
        public Avaliation(int rating, string description, Guid userId, Guid bookId,DateTime startedDate,DateTime finishedDate)
        {
            Id=Guid.NewGuid();
            Rating = rating;
            Description = description;
            UserId = userId;
            BookId = bookId;
            CreatedDate = DateTime.Now;
            StartedDate = startedDate;
            FinishedDate = finishedDate;
        }
        public void UpdateAvaliation(string description,int rating)
        {
            Description = description;
            Rating = rating;
        }
    }
}
