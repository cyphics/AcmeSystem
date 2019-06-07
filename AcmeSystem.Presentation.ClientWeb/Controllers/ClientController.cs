using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcmeSystem.Business;
using AcmeSystem.Presentation.ClientWeb.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcmeSystem.Presentation.ClientWeb.Controllers
{
    public class ClientController : Controller
    {
        IClientServices _clientServices;
        public int PageSize = 4;

        public ClientController(IClientServices clientServices)
        {
            _clientServices = clientServices;
        }

        public ViewResult List(int clientPage = 1)
            => View(new ClientListViewModel
            {
                Clients = _clientServices.GetAll()
                .OrderBy(c => c.Nom)
                .Skip((clientPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = clientPage,
                    ItemsPerPage = PageSize,
                    TotalItems = _clientServices.GetAll().Count()
                }
            });
    }
}