using AcmeSystem.Business.Contacts;
using System;

namespace AcmeSystem.Business.Clients
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Adresse Adresse { get; set; }

        public override string ToString()
        {
            return Prenom + " " + Nom;
        }
    }
}
