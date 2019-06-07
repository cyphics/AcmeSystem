using AcmeSystem.Business.Contacts;
using System.Collections.Generic;

namespace AcmeSystem.Business.Clients
{
    public class ClientFactory
    {
        public static Client CreateClient(string nom, string prenom, string rue, string num, string npa, string localite)
        {
            Adresse adresse = new Adresse()
            {
                Rue = rue,
                Numero = num,
                Npa = npa,
                Localite = localite,
            };

            return new Client()
            {
                Nom = nom,
                Prenom = prenom,
                Adresse = adresse
            };
        }

        public static ICollection<Client> GetFakeClients()
        {
            ICollection<Client> clients = new List<Client>()
            {
               ClientFactory.CreateClient("Moore", "Alan", "Gravity street", "25", "1042", "London"),
                    ClientFactory.CreateClient("Benson", "Georges", "Baker street", "121b", "1000", "London"),
                    ClientFactory.CreateClient("Mercury", "Georges", "Rue de la Science", "232", "1019", "Paris"),
                    ClientFactory.CreateClient("Plant", "Robert", "Rue de la programmation", "43", "1236", "Paris"),
                    ClientFactory.CreateClient("Vicious", "Sid", "Rue du vaccin", "154", "1457", "Paris"),
                    ClientFactory.CreateClient("Red", "Axelle", "Rue du vaccin", "12", "1201", "London"),
                    ClientFactory.CreateClient("Rose", "Axel", "Magnetic Street", "47", "2589", "Edinbourg"),
                    ClientFactory.CreateClient("Clapton", "Eric", "Electric Street", "547", "6021", "New York"),
                    ClientFactory.CreateClient("Cash", "Johnny", "Light Street", "584", "3010", "Boston"),
                    ClientFactory.CreateClient("Jackson", "Michael", "Rue du Radium", "11", "1912", "Paris"),
                    ClientFactory.CreateClient("Dufoin", "Trevor", "Dynamo Street", "87", "1879", "London")
                    };

            return clients;
        }
    }
}
