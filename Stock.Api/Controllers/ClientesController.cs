using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Stock.Data;
using Stock.Dto;
using Stock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteRepository clienteRepository;
        private readonly IMapper mapper;
        private readonly LinkGenerator linkGenerator;

        public ClientesController(ClienteRepository clienteRepository, IMapper mapper, LinkGenerator linkGenerator)
        {
            this.clienteRepository = clienteRepository;
            this.mapper = mapper;
            this.linkGenerator = linkGenerator;
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

        [HttpGet("{Id_Clientes:int}")]
        public ActionResult<ClienteDto> Obtener(int Id_Clientes, bool IncluirDatosVendedor = true)
        {
            try
            {
                ClienteDto Retorno = null;

                if (IncluirDatosVendedor)
                {
                    Retorno = mapper.Map<ClienteDto>(clienteRepository.Obtener(Id_Clientes));
                }
                else
                {
                    Retorno = mapper.Map<ClienteDto>(clienteRepository.ObtenerSinVendedor(Id_Clientes));
                }

                if (Retorno == null) return NotFound();

                return Retorno;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Ocurrió este error: {ex.Message}");
            }
        }

        [HttpGet("buscarpornombre")]
        public ActionResult<List<ClienteDto>> ObtenerPorNombre(string Filtro = "")
        {
            try
            {
                var Listado = clienteRepository.ObtenerPorNombre(Filtro);

                if (!Listado.Any()) return NotFound();

                return mapper.Map<List<ClienteDto>>(Listado);
            }
            catch (Exception ex)
            {
                //return BadRequest($"Ocurrió este error: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, $"Ocurrió este error: {ex.Message}");
            }
        }


        public ActionResult<ClienteDto> Post(ClienteDto clienteDto)
        {
            try
            {
                //CREAR NUEVO CLIENTE 

                if (clienteRepository.ObtenerPorCedula(clienteDto.Cedula) != null)
                {
                    return BadRequest("Ya existe un cliente con esa cedula");
                }

                Cliente cliente = mapper.Map<Cliente>(clienteDto);

                //if (string.IsNullOrWhiteSpace(clienteDto.PrimerNombre))
                //{
                //    return BadRequest("El primer nombre es obligatorio");
                //}

                cliente.EsNuevo = true;
                cliente.Modificado = true;

                clienteRepository.Grabar(ref cliente);

                var DireccionClienteNuevo = linkGenerator.GetPathByAction("Obtener",
                    "Clientes",
                    new { Id_Clientes = cliente.Id_Clientes });

                if (string.IsNullOrWhiteSpace(DireccionClienteNuevo))
                {
                    return BadRequest("Se necesita un codigo para el cliente");
                }

                return Created(DireccionClienteNuevo, mapper.Map<ClienteDto>(cliente));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Ocurrió este error: {ex.Message}");
            }
        }

    }
}
