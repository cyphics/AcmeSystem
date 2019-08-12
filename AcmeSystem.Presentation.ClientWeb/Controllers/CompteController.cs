using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AcmeSystem.Business;
using AcmeSystem.Presentation.ClientWeb.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using AcmeSystem.Business.Comptes;

namespace AcmeSystem.Presentation.ClientWeb.Controllers
{
    public class CompteController : Controller
    {
        ICompteServices _compteServices;
        public int PageSize = 4;

        public CompteController(ICompteServices compteServices)
        {
            _compteServices = compteServices;
        }

        public ViewResult Index()
        {
            return View(_compteServices.GetAll());
        }

        [Authorize]
        public ViewResult List(int contactPage = 1)
            => View(new CompteListViewModel
            {
                Comptes = _compteServices.GetAll()
                    .OrderBy(c => c.Nom)
                    .Skip((contactPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = contactPage,
                    ItemsPerPage = PageSize,
                    TotalItems = _compteServices.GetAll().Count()
                }
            });
   
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,DateCreation,DateModification")] Compte compte)
        {
            if (ModelState.IsValid)
            {
                _compteServices.Create(compte);
            }
            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Edit(int id)
        {

            var compte = _compteServices.FindById(id);
            if (compte == null)
            {
                return NotFound();
            }
            return View(compte);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,DateCreation,DateModification")] Compte compte)
        {
            if (id != compte.Id)
            {
                return NotFound();
            }

            _compteServices.Edit(compte);
            return RedirectToAction(nameof(List));
        }

        public async Task<IActionResult> Delete(int id)
        {
                var compte = _compteServices.FindById(id);
                if (compte == null)
                {
                    return NotFound();
                }

                return View(compte);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compte = _compteServices.FindById(id);
            if (compte == null)
                return NotFound();
            _compteServices.Delete(compte);
            
            return RedirectToAction(nameof(List));
        }
    }
}

