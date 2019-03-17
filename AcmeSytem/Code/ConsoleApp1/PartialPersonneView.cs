using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PartialPersonneView : IView
    {
        public override void Update(Personne personne)
        {
            Console.WriteLine(personne.Nom + " Age : " + personne.Age);
            Console.WriteLine(base._controleur);

        }
    }
}

