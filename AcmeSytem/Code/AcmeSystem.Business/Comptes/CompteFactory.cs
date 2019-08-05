using AcmeSystem.Business.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeSystem.Business.Comptes
{
    public class CompteFactory
    {
        public static Compte CreateCompte(string nom, string rue, string num, string npa, string localite)
        {
            Adresse adresse = new Adresse()
            {
                Rue = rue,
                Numero = num,
                Npa = npa,
                Localite = localite,
            };

            return new Compte()
            {
                Nom = nom,
                Adresse = adresse,
                DateCreation = DateTime.Today,
                DateModification = DateTime.Today
            };
        }

        public static ICollection<Compte> GetFakeComptes()
        {
            ICollection<Compte> contacts = new List<Compte>()
            {
                CreateCompte("Newton_Mock", "Gravity street", "25", "1042", "London"),
                CreateCompte("Holmes_Mock","Baker street", "121b", "1000", "London"),
                CreateCompte("Babbage_Mock","Rue de la Science", "232", "1019", "Paris"),
                CreateCompte("Lovelace_Mock","Rue de la programmation", "43", "1236", "Paris"),
                CreateCompte("Pasteur_Mock","Rue du vaccin", "154", "1457", "Paris"),
                CreateCompte("Turing_Mock","Rue du vaccin", "12", "1201", "London"),
                CreateCompte("Maxwell_Mock", "Magnetic Street", "47", "2589", "Edinbourg"),
                CreateCompte("Tesla_Mock", "Electric Street", "547", "6021", "New York"),
                CreateCompte("Edison_Mock", "Light Street", "584", "3010", "Boston"),
                CreateCompte("Curie_Mock", "Rue du Radium", "11", "1912", "Paris"),
                CreateCompte("Faraday_Mock", "Dynamo Street", "87", "1879", "London"),
            };

            return contacts;
        }
    }
}

