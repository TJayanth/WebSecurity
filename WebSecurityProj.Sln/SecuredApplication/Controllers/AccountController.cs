using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecuredApplication.Models;

namespace SecuredApplication.Controllers
{
    public class AccountController : AbstractController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Transfer()
        {
            TransferMoneyDTO transferMoneyDTO = new TransferMoneyDTO();
            return View(transferMoneyDTO);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Transfer(TransferMoneyDTO transferMoneyDTO)
        {
            transferMoneyDTO.IsTransfered = true;
            return View(transferMoneyDTO);
        }

        [HttpGet]
        [AutoValidateAntiforgeryToken]
        public IActionResult Login()
        {
            LoginDTO loginDto = new LoginDTO();
            return View(loginDto);
        }

        [HttpPost]
        //[AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginDTO loginDto, string returnUrl)
        {
            var claims = new List<Claim>{
                            new Claim(ClaimTypes.Name,loginDto.Email),
                            new Claim(ClaimTypes.Email,loginDto.Email),
                            new Claim("Password",loginDto.Password),

        };

            //Create Claims Identity for the claims
            var authClaimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            //Create Claims Prinicpal for the Claims Identity which will be stored in Cached memory
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(authClaimsIdentity);

            //Create Authentication Ticket using the generated claims principal
            AuthenticationTicket authenticationTicket = new AuthenticationTicket(claimsPrincipal, CookieAuthenticationDefaults.AuthenticationScheme);

            //Cached key will be stored as claims Identity in the client side for all the subsequent request
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            //Sign in the context using the claims identity which has the cacehed key
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            Response.Cookies.Append("Email", loginDto.Email,new CookieOptions { HttpOnly=true});
            Response.Cookies.Append("Password", loginDto.Password, new CookieOptions { HttpOnly = true });
            if (!String.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            return View(loginDto);
        }
    }
}