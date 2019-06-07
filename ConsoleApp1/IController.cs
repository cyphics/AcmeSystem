using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IController
    {
        void AttachView(IView view);
        void OnPersonneChange(Personne personne);
    }
}
