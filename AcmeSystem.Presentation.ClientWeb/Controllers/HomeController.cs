using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcmeSystem.Business;
using AcmeSystem.Presentation.ClientWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace AcmeSystem.Presentation.ClientWeb.Controllers
{
    public class HomeController : Controller
    {
        IContactServices _contactServices;
        IClientServices _ervices;

        public HomeController(IContactServices contactServices)
        {
            _contactServices = contactServices;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
