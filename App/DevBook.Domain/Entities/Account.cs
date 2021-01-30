namespace DevBook.Domain.Entities
{
    public class Account : Entity
    {
        public Account() { }

        public string EmailOrCPF { get; private set; }
        public string Password { get; private set; }
    }
}
