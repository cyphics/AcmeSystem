using AcmeSystem.Business.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeSystem.Business.Comptes
{
    public class Compte
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Adresse Adresse { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }

        public override string ToString()
        {
            return Nom;
        }
    }
}
