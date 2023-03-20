using ProjetoAgenda;


List<Contact> phoneBook = new List<Contact>();


Contact contact = new Contact("Naiara", "333-1234");
contact.Address.EditStreet("Rua Nove de Julho, 2100");
contact.Address.EditCity("Araraquara");
contact.Address.EditState("Sao Paulo");
contact.Address.EditPostalCode("12895-000");
contact.Address.EditCountry("Brasil");

Contact contact2 = new Contact("Sheldon", "333-1234");
contact2.Address.EditStreet("Rua do Sheldon, 2100");
contact2.Address.EditCity("Passadena");
contact2.Address.EditState("California");
contact2.Address.EditPostalCode("91001-000");
contact2.Address.EditCountry("EUA");

int op;
do
{
    op = Menu();
    switch (op)
    {
        case 1:
            phoneBook.Add(CreateContact());
            break;
        case 2:
            EditContact(FindContact());
            break;
        case 3:
            phoneBook.Remove(FindContact());
            break;
        case 4:
            PrintPhoneBook(phoneBook);
            break;
        case 5:
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
} while (true);

Contact FindContact()
{
    Console.WriteLine("Informe o nome: ");
    var n = Console.ReadLine();
    foreach (var item in phoneBook)
    {
        if (item.Name.Equals(n))
        {
            return item;
        }
    }
    return null;
}

Contact CreateContact()
{
    Console.WriteLine("Informe o nome: ");
    string name = Console.ReadLine();
    Console.WriteLine("Informe o telefone: ");
    string phone = Console.ReadLine();
    Contact contact = new(name, phone);
    return contact;
}


void PrintPhoneBook(List<Contact> l)
{
    foreach (var item in l)
    {
        Console.WriteLine(item);
    }

}
int Menu()
{
    Console.WriteLine("Menu de Opções\n1-Insere Contato" + "\n2-EditarContato" + "\n3-Remover Contato" + "\n4-Mostrar Agenda" + "\n5-Sair" + "\n\nEscolha uma opção: ");
    var op = int.Parse(Console.ReadLine());
    return op;

}



int ChooseEditContact()
{
    Console.WriteLine("Menu de Opções\n1-Editar Nome" + "\n2-Editar Telefone" + "\n3-Editar Email" + "\n4-Editar Rua" + "\n5-Editar Cidade" + "\n6-Editar Estado"+ "\n7- Editar Código Postal" + "\n 8- Editar País" + "\n9-Sair"+"\n\nEscolha uma opção: ");
    var op = int.Parse(Console.ReadLine());
    return op;

}

void EditContact(Contact contact)
{
    do
    {
        switch (ChooseEditContact())
        {
            case 1:

                Console.WriteLine("Digite o novo Nome");
                string name = Console.ReadLine();
                contact.Name = name;
                break;

            case 2:

                Console.WriteLine("Digite o novo Telefone");
                string phone = Console.ReadLine();
                contact.EditPhone(phone);
                break;

            case 3:
                Console.WriteLine("Digite o novo Email");
                string email = Console.ReadLine();
                contact.EditEmail(email);
                break;

            case 4:
                Console.WriteLine("Digite o novo nome da rua do seu endereço: ");
                string street = Console.ReadLine();
                contact.Address.EditStreet(street);
                break;

            case 5:
                Console.WriteLine("Digite o novo nome da cidade do seu endereço: ");
                string city = Console.ReadLine();
                contact.Address.EditCity(city);
                break;

            case 6:
                Console.WriteLine("Digite o novo nome do estado do seu endereço: ");
                string state = Console.ReadLine();
                contact.Address.EditState(state);
                break;

            case 7:
                Console.WriteLine("Digite o novo código postal do seu endereço: ");
                string postalCode = Console.ReadLine();
                contact.Address.EditPostalCode(postalCode);
                break;

            case 8:
                Console.WriteLine("Digite o novo nome do país do seu endereço: ");
                string country = Console.ReadLine();
                contact.Address.EditCountry(country);
                break;
            case 9:
                System.Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção Inválida");
                break;
        }

    } while (true);
}
