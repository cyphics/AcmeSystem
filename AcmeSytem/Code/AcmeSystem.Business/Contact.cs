using System;

namespace AcmeSystem.Business
{
    public class Contact
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public override string ToString()
        {
            return Prenom + " " + Nom;
        }
    }
}
