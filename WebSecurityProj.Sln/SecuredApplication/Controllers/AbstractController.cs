using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SecuredApplication.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AbstractController : Controller
    {
        
    }
}