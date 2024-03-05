namespace GerenciadorLivros.Domain.Entitites
{
    public class Avaliation
    {
        public Guid Id { get; set; }

        public int Rating { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime StartedDate { get; set; }

        public DateTime FinishedDate { get; set; }

        public Avaliation() { }
        public Avaliation(int rating, string description, int userId, int bookId)
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
