

namespace ProjetoAgenda
{
    internal class Contact
    {
        public Contact()
        {
        }

        public string Name { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }

        public Contact(string name, Address address, string phone, string? email)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
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

            return $"{Name}|{Phone}|{Address}";
        }


        //public override string ToUser()
        //{
         
        //    return $"\n\nNome: {Name}\nTelefone:{Phone}\nEndereço: {Address}";
        //}
    }
}
