using Metier;
using MockPersistence;
using Services;
using SqlServerPersistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonnePersistence _personnePersistence = new SqlServerPersonnesRepository();
            IPersonnePersistence _personnePersistence = new MockPersonnesRepository();
            

            IPersonneServices _personneServices = new PersonneServices(_personnePersistence);
            
            //-Aficher toutes les personnes du carnet d'adresse

            foreach (Personne p in _personneServices.GetAllPersonnes())
                Console.WriteLine(p);

            Console.ReadLine();
        }
    }
}
