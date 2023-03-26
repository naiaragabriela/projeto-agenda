

namespace ProjetoAgenda
{
    internal class Contact
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }

        public Contact()
        {
        }
        public void EditName(string name)
        {
            this.Name= name;
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
            return $"{Name}|{Phone}|{Address}|{Email}|";
        }
        public string ToUser()
        {
            return $"\n\nNome: {Name}\nTelefone:{Phone}\nEndereço: {Address.ToUser()}\nEmail:{Email}";
        }
    }
}
