using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock.Data;
using Stock.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteRepository clienteRepository;
        private readonly IMapper mapper;

        public ClientesController(ClienteRepository clienteRepository, IMapper mapper)
        {
            this.clienteRepository = clienteRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<ClienteDto>> Obtener()
        {
            try
            {
                //return this. NotFound("NO se encontró ningun registro");
                //return BadRequest("Ha Ocurrido Un Error");
                //ClienteRepository clienteRepository = new ClienteRepository();

                //return Ok(new { Id_Clientes = 1, PrimerNombre = "Leonardo" });

                //return Ok(clienteRepository.Obtener());

                //var Listado = clienteRepository.Obtener();
                //var ListadoRetorno = new List<ClienteDto>();

                //foreach (var cliente in Listado)
                //{
                //    ClienteDto NuevoClienteDto = new ClienteDto();

                //    NuevoClienteDto.Id_Clientes = cliente.Id_Clientes;
                //    NuevoClienteDto.PrimerNombre = cliente.PrimerNombre;

                //    ListadoRetorno.Add(NuevoClienteDto);
                //}

                var Listado = clienteRepository.Obtener();
                return mapper.Map<List<ClienteDto>>(Listado);

            }
            catch (Exception ex)
            {
                //return BadRequest($"Ocurrió este error: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, $"Ocurrió este error: {ex.Message}");
            }

        }
    }
}
