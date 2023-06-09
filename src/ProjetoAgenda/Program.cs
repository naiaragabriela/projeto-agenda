﻿using ProjetoAgenda;


int op;
do
{
    var phoneBook = LoadFile();
    op = Menu();
    switch (op)
    {
        case 1:
            var newContact = CreateContact();
            phoneBook.Add(newContact);
            WriteFile(phoneBook);
            break;
        case 2:
            var editContact = FindContact(phoneBook);
            EditContact(editContact);
            int position = phoneBook.IndexOf(editContact);
            phoneBook[position] = editContact;
            WriteFile(phoneBook);
            break;
        case 3:
            var removeContact = FindContact(phoneBook);
            phoneBook.Remove(removeContact);
            WriteFile(phoneBook); 
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

void WriteFile(List<Contact> list)
{
    string contact = "";

    foreach (Contact c in list)
    {
        contact += c.ToString() + "\n";
    }
    try
    {
        StreamWriter sw = new StreamWriter("AgendaDeContatos.txt");
        if (!string.IsNullOrWhiteSpace(contact))
        {
            sw.WriteLine(contact);
        }
        sw.Close();
    }
    catch (Exception)
    {
        throw;
    }
    finally
    {
        Console.WriteLine("Registro gravado com sucesso!");
        Thread.Sleep(1000);
    }
}
List<Contact> LoadFile()
{
    if (!File.Exists("AgendaDeContatos.txt"))
    {
        StreamWriter sw = new StreamWriter("AgendaDeContatos.txt");
        sw.Close();
    }
    StreamReader sr = new StreamReader("AgendaDeContatos.txt");
    string textContact = "";
    List<Contact> phoneBook = new List<Contact>();
    while (!string.IsNullOrEmpty(textContact = sr.ReadLine()))
    {
        var values = textContact.Split("|");
        Contact newContact = new Contact();
        Address newAddress = new Address();
        newContact.Name = values[0];
        newContact.Phone = values[1];
        newAddress.Street = values[2];
        newAddress.City = values[3];
        newAddress.State = values[4];
        newAddress.PostalCode = values[5];
        newAddress.Country = values[6];
        newContact.Address = newAddress;
        newContact.Email = values[7];
        phoneBook.Add(newContact);
    }
    sr.Close();
    return phoneBook;
}
Contact FindContact(List<Contact> phoneBook)
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
    Contact contact = new Contact();
    Console.WriteLine("Informe o nome: ");
    string name = Console.ReadLine();
    contact.EditName(name);
    Console.WriteLine("Informe o telefone: ");
    string phone = Console.ReadLine();
    contact.EditPhone(phone);
    Console.WriteLine("Informe o endereço deste contato: ");
    Address address = new Address();
    Console.WriteLine("Digite a rua com o número: ");
    string street = Console.ReadLine();
    address.EditStreet(street);
    Console.WriteLine("Informe a cidade: ");
    string city = Console.ReadLine();
    address.EditCity(city);
    Console.WriteLine("Informe o estado: ");
    string state = Console.ReadLine();
    address.EditState(state);
    Console.WriteLine("Informe o código postal deste endereço:");
    string postalCode = Console.ReadLine();
    address.EditPostalCode(postalCode);
    Console.WriteLine("Informe o país:");
    string country = Console.ReadLine();
    address.EditCountry(country);
    contact.Address = address;
    Console.WriteLine("Informe o e-mail deste contato: ");
    string email = Console.ReadLine();
    contact.EditEmail(email);
    return contact;
}
void PrintPhoneBook(List<Contact> l)
{
    foreach (var item in l)
    {
        Console.WriteLine(item.ToUser());
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
    Console.WriteLine("Escolha uma opção:\n\n" + "\n1-Editar Nome" + "\n2-Editar Telefone" + "\n3-Editar Email" + "\n4-Editar Rua" + "\n5-Editar Cidade" + "\n6-Editar Estado" + "\n7- Editar Código Postal" + "\n 8- Editar País" + "\n9-Sair");
    var op = int.Parse(Console.ReadLine());
    return op;
}
void EditContact(Contact contact)
{
    do
    {  if (contact != null)
        {
            switch (ChooseEditContact())
            {
                case 1:
                    Console.WriteLine("Digite o novo Nome");
                    string name = Console.ReadLine();
                    contact.EditName(name);
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
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        } else
        {
            Console.WriteLine("Resposta Inválida \n\n");

            Menu();
        }
    } while (true);
}
