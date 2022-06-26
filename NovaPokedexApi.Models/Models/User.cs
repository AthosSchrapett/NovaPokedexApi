namespace NovaPokedexApi.Models
{
    public class User : Login
    {
        public Guid Id { get; set; }
        public DateTime CreatedIn { get; }


        public User()
        {
            Id = Guid.NewGuid();
            CreatedIn = DateTime.Now;
        }
    }
}
