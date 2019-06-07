using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Controller : IController
    {
        List<IView> _views = new List<IView>();

        public void AttachView(IView view)
        {
            _views.Add(view);
            view.AttachController(this);
        }

        public void OnPersonneChange(Personne personne)
        {
            foreach (IView view in _views)
            {
                view.Update(personne);
            }
        }
    }
}
