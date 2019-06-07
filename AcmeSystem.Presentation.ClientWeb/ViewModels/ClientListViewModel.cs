using AcmeSystem.Business.Clients;
using System.Collections.Generic;

namespace AcmeSystem.Presentation.ClientWeb.ViewModels
{
    public class ClientListViewModel
    {
        public IEnumerable<Client> Clients { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
