using AcmeSystem.Applicative.Services;
using AcmeSystem.Business;
using AcmeSystem.Business.Contacts;
using AcmeSystem.Persistence.MockRepositories;
using System;
using System.Collections.Generic;

namespace AcmeSystem.Presentation.ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IContactRepository contactRespository = new ContactRepositoryMock();

            IContactServices contacts = new ContactServices(contactRespository);
           
            Console.WriteLine("Bienvenu au AcmeSyste Application...");
            Console.WriteLine();

            foreach ( Contact contact in contacts.GetAll())
            {
                Console.WriteLine(contact);
            }

            var c = ContactFactory.CreateContact("toto", "titi", "rue", "1", "1000", "Lausanne");


            Console.ReadLine();
        }
    }
}
