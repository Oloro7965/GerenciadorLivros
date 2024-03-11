namespace GerenciadorLivros.Domain.Entitites
{
    public class Avaliation
    {
        public Guid Id { get; set; }

        public int Rating { get; set; }

        public string Description { get; set; }

        public Guid UserId { get; set; }

        public Guid BookId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime StartedDate { get; set; }

        public DateTime FinishedDate { get; set; }

        public Avaliation() { }
        public Avaliation(int rating, string description, Guid userId, Guid bookId)
        {
            Id=Guid.NewGuid();
            Rating = rating;
            Description = description;
            UserId = userId;
            BookId = bookId;
            CreatedDate = DateTime.Now;
        }
    }
}
