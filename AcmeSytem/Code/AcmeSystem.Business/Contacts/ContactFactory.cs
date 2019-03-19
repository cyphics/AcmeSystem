using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeSystem.Business.Contacts
{
    public class ContactFactory
    {
        public static Contact CreateContact(string nom, string prenom, string rue, string num, string npa, string localite)
        {
            Adresse adresse = new Adresse()
            {
                Rue = rue,
                Numero = num,
                Npa = npa,
                Localite = localite,
            };

            return new Contact()
            {
                Nom = nom,
                Prenom = prenom,
                Adresse = adresse
            };
        }

        public static List<Contact> GetFakeContacts()
        {
            List<Contact> contacts = new List<Contact>()
            {
                CreateContact("Newton", "Isac", "Gravity street", "25", "1042", "London"),
                CreateContact("Holmes", "Sherlock", "Baker street", "121b", "1000", "London"),
                CreateContact("Babbage", "Charles", "Rue de la Science", "232", "1019", "Paris"),
                CreateContact("Lovelace", "Ada", "Rue de la programmation", "43", "1236", "Paris"),
                CreateContact("Pasteur", "Louis", "Rue du vaccin", "154", "1457", "Paris"),
                CreateContact("Turing", "Alan", "Rue du vaccin", "12", "1201", "London"),
                CreateContact("Maxwell", "James", "Magnetic Street", "47", "2589", "Edinbourg"),
                CreateContact("Tesla", "Nikola", "Electric Street", "547", "6021", "New York"),
                CreateContact("Edison", "Thomas", "Light Street", "584", "3010", "Boston"),
                CreateContact("Curie", "Marie", "Rue du Radium", "11", "1912", "Paris"),
                CreateContact("Faraday", "Michael", "Dynamo Street", "87", "1879", "London"),
            };

            return contacts;
        }
    }
}
