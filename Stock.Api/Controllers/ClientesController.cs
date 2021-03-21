using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Obtener()
        {
            //return this. NotFound("NO se encontró ningun registro");
            //return BadRequest("Ha Ocurrido Un Error");
            
            return Ok(new { Id_Clientes = 1, PrimerNombre = "Leonardo" });
        }
    }
}
