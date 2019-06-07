using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class IView
    {
        protected IController _controleur;

        public void AttachController(IController controleur)
        {
            _controleur = controleur;
        }
        public abstract void Update(Personne personne);
    }
}
