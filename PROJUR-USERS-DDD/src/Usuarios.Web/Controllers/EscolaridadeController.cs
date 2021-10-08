using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usuarios.Application.Controllers
{
    public class EscolaridadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
