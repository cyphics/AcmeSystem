using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            

            IController controller = new Controller();

            PersonneView p1 = new PersonneView();
            controller.AttachView(p1);
            PartialPersonneView p2 = new PartialPersonneView();
            controller.AttachView(p2 );

            Personne personne = new Personne() { Prenom = "Albert", Nom = "Einstein", Age = "65" };

            controller.OnPersonneChange(personne);

            personne.Age = "35";

            controller.OnPersonneChange(personne);

            Console.ReadKey();

            p1.click();

            Console.ReadKey();
        }
    }
}
