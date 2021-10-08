using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Domain.Entities;
using Usuarios.Domain.Interfaces;

namespace Escolaridades.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EscolaridadeController : ControllerBase
    {
        private IBaseService<Escolaridade> _baseEscolaridadeService;

        public EscolaridadeController(IBaseService<Escolaridade> baseEscolaridadeService)
        {
            _baseEscolaridadeService = baseEscolaridadeService;
        }

 
        [HttpGet()]
        public IActionResult Get()
        {
            return Execute(() => _baseEscolaridadeService.Get());
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
