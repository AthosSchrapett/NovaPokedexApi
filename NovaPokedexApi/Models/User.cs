namespace NovaPokedexApi.Models
{
    public class User
    {
        public Guid Id { get; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedIn { get; }


        public User()
        {
            Id = Guid.NewGuid();
            CreatedIn = DateTime.Now;
        }
    }
}
