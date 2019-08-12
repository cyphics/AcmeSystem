using AcmeSystem.Business.Comptes;
using System.Collections.Generic;

namespace AcmeSystem.Presentation.ClientWeb.ViewModels
{
    public class CompteListViewModel
    {
        public IEnumerable<Compte> Comptes { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
