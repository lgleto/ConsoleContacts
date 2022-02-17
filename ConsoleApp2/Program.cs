using System;
using System.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace MyNamespace
{
    
    public class Example
    {
        private static List<Contact> contacts = new List<Contact>();

        static void Main()
        {
            int option = -1;
            do
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1. Inserir");
                Console.WriteLine("2. Listar todos");
                Console.WriteLine("3. Listar por nome");
                Console.WriteLine("4. Remover contacto");
                Console.WriteLine("5. Editar contacto");
                Console.WriteLine("0. Sair");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        insertContact();
                        break;
                    case 2:
                        listContacts();
                        break;
                    case 3:
                        listContactsWithName();
                        break;
                    case 4:
                        removeContactWithName();
                        break;
                    case 5:
                        updateContactWithName();
                        break;
                    case 0:
                        Console.WriteLine("Adeus!");
                        break;
                    
                }

            } while (option != 0);
        }

        static void listContacts()
        {
            foreach (var contact in contacts)
            {
                contact.DisplayContact(); 
            }
        }

        static void listContactsWithName()
        {
            Console.WriteLine("Insira o nome:");
            string name = Console.ReadLine();
            foreach (var contact in contacts)
            {
                if (contact.Name.StartsWith(name))
                {
                    contact.DisplayContact();
                    return;
                }
            }
            Console.WriteLine("Não existem contactos com esse nome.");
        }

        
        static void insertContact()
        {
            Console.WriteLine("Insira o nome:");
            string name = Console.ReadLine();
            Console.WriteLine("Insira a morada:");
            string address = Console.ReadLine();
            Console.WriteLine("Insira o telefone:");
            string phone = Console.ReadLine();
            Contact contact = new Contact(name, address, phone);
            contacts.Add(contact);
        }

        static void removeContactWithName()
        {
            Console.WriteLine("Insira o nome:");
            string name = Console.ReadLine();
            Contact contactToRemove = null;
            foreach (var contact in contacts)
            {
                if (contact.Name == name)
                {
                    contactToRemove = contact;
                    break;
                }
            }
            if (contactToRemove != null) contacts.Remove(contactToRemove);
        }
        
        static void updateContactWithName()
        {
            Console.WriteLine("Insira o nome:");
            string name = Console.ReadLine();
          
            foreach (var contact in contacts)
            {
                if (contact.Name == name)
                {
                    Console.WriteLine("Insira a nova morada:");
                    string address = Console.ReadLine();
                    Console.WriteLine("Insira o novo telefone:");
                    string phone = Console.ReadLine();
                    contact.Address = address;
                    contact.Phone = phone;
                    break;
                }
            }
            
        }
    }

    


}