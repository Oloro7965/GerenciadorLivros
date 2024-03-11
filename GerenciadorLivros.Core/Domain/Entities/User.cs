namespace GerenciadorLivros.Domain.Entitites
{
    public class User
    {
        public Guid Id { get; private set; }

        public string Email { get; private set; }

        public string Name { get; private set; }

        public List<Avaliation> UserAvaliations { get; private set; }
        public bool IsDeleted { get; private set; }

        public User()
        {
        }

        public User(string email, string name)
        {
            Id = Guid.NewGuid();
            Email = email;
            Name = name;
            UserAvaliations = new List<Avaliation>();
            IsDeleted = false;
        }
        public void Delete() {
            IsDeleted = true;
        }
    }
}
