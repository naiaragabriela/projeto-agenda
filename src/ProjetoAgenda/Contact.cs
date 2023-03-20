

namespace ProjetoAgenda
{
    internal class Contact
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }

        public Contact (string name, string phone)
        {
            this.Name = name;
            this.Address = new Address(); 
            this.Phone = phone;

        }
        public void EditPhone(string phone)
        {
            this.Phone = phone;
        }

        public void EditEmail(string email)
        {
            this.Email = email;
        }

        public override string ToString()
        {
         
            return $"\n\nNome: {Name}\nTelefone:{Phone}{Address}";
        }
    }
}
