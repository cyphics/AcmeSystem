using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>

    /// The 'ConcreteObserver' class

    /// </summary>

    public class PersonneView : IView
    {
        Personne _pesonne;
        public override void Update(Personne pesonne)
        {
            _pesonne = pesonne;
            Console.WriteLine(pesonne);
            Console.WriteLine();
        }

        public void click()
        {
            _pesonne.Nom = _pesonne.Nom + "PersonneView";
            base._controleur.OnPersonneChange(_pesonne);
        }
    }
}

