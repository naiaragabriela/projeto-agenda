
namespace ProjetoAgenda
{
    internal class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public Address(string street, string city, string state, string postalCode, string country)
        {
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }

        public void EditStreet(string street)
        {
            this.Street = street;
        }
        public void EditCity(string city)
        {
            this.City = city;
        }
        public void EditState(string state)
        {
            this.State = state;
        }
        public void EditPostalCode(string postalCode)
        {
            this.PostalCode = postalCode;
        }
        public void EditCountry(string country)
        {
            this.Country = country;
        }
        public override string ToString()
        {
            return Street + "|" + City + "|" + State + "|" + PostalCode + "|" + Country + "|";
        }
        //public override string ToUser()
        //{
        //    return "Endereço: " + Street + "\nCidade: " + City + "\nEstado: "+ State +"\nPostalCode: " + PostalCode + "\nPaís: " + Country + ".";
        //}
    }
}
