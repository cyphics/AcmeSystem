using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcmeSystem.Presentation.ClientWeb.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using AcmeSystem.Business;
using AcmeSystem.Business.Users;

namespace AcmeSystem.Presentation.ClientWeb.Controllers
{
    public class IdentificationController : Controller
    {
        IUserServices _userServices;
        public IdentificationController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        [Route("identification/login")]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [Route("identification/login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var user = _userServices.Validate(loginViewModel.UserName, loginViewModel.Password);

                await Authentification(user);

                return RedirectToLocal(returnUrl);
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(IdentificationController.Login));
        }


        #region Helpers

        private void AddErrors(string message)
        {
            ModelState.AddModelError(string.Empty, message);
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else

            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        private async Task Authentification(User user)
        {
            ClaimsIdentity identity = new ClaimsIdentity(GetClaims(user), CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            await this.HttpContext.SignInAsync(
              CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties() { IsPersistent = false });
        }

        private IEnumerable<Claim> GetClaims(User user)
        {
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Prenom));
            claims.Add(new Claim(ClaimTypes.Name, user.Nom));
            claims.Add(new Claim(ClaimTypes.Surname, user.UserName));

            return claims;
        }

        #endregion

    }
}