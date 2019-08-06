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

        /*
        public ViewResult Index()
        {
            return View(_contactServices.GetAll());
        }
        */

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
   

        //    GET: Comptes/Create
        public IActionResult Create()
        {
            return View();
        }

        //    POST: Comptes/Create
        //    To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //     more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,DateCreation,DateModification")] Compte compte)
        {
            if (ModelState.IsValid)
            {
                _compteServices.Create(compte);
                //await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            }
            return View(compte);
        }

        //    GET: Comptes/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            var compte = _compteServices.FindById(id);
            if (compte == null)
            {
                return NotFound();
            }
            return View(compte);

        }
        //    POST: Comptes/Edit/5
        //     To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //     more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,DateCreation,DateModification")] Compte compte)
        {
            if (id != compte.Id)
            {
                return NotFound();
            }

            _compteServices.Edit(compte);
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(compte);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!CompteExists(compte.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            return View(compte);
        }

        //    GET: Comptes/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
                var compte = _compteServices.FindById(id);
                if (compte == null)
                {
                    return NotFound();
                }

                return View(compte);
        }

        //    POST: Comptes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compte = _compteServices.FindById(id);
            if (compte == null)
                return NotFound();
            _compteServices.Delete(compte);
            return RedirectToAction(nameof(Compte));
            //var compte = await _context.Comptes.FindAsync(id);
            //_context.Comptes.Remove(compte);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        }

        //private bool CompteExists(int id)
        //{
        //    return _context.Comptes.Any(e => e.Id == id);
        //}
    }
}

