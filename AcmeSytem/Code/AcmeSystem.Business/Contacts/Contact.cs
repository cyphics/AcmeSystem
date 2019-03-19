using System;

namespace AcmeSystem.Business.Contacts
{
    public class Contact
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Adresse Adresse { get; set; }

        public override string ToString()
        {
            return Prenom + " " + Nom;
        }
    }
}
