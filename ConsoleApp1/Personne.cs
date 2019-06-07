using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Age { get; set; }

        public override string ToString()
        {
            return Prenom + " " + Nom + " - Age : " + Age;
        }
    }
}
