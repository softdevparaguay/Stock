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
    [ApiController]
    [Route("api/clientes/{Id_Clientes}/ventas")]
    public class VentasController : ControllerBase
    {
        private readonly VentaRepository ventaRepository;
        private readonly ClienteRepository clienteRepository;
        private readonly IMapper mapper;
        private readonly LinkGenerator linkGenerator;

        public VentasController(VentaRepository ventaRepository,
                                ClienteRepository clienteRepository,
                                IMapper mapper,
                                LinkGenerator linkGenerator)
        {
            this.ventaRepository = ventaRepository;
            this.clienteRepository = clienteRepository;
            this.mapper = mapper;
            this.linkGenerator = linkGenerator;
        }

        [HttpGet()]
        public ActionResult<List<VentaDto>> Obtener(int Id_Clientes)
        {
            try
            {
                var VentasDelCliente = ventaRepository.ObtenerPorId_Clientes(Id_Clientes);

                if (VentasDelCliente == null || VentasDelCliente.Count == 0) return NotFound();

                return mapper.Map<List<VentaDto>>(VentasDelCliente);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Ocurrió este error: {ex.Message}");
            }
        }

        [HttpGet("{Id_Ventas:int}")]
        public ActionResult<VentaDto> Obtener(int Id_Clientes, int Id_Ventas)
        {
            try
            {
                var VentaDelCliente = ventaRepository.ObtenerPorId_Clientes(Id_Clientes, Id_Ventas);

                if (VentaDelCliente == null) return NotFound();

                return mapper.Map<VentaDto>(VentaDelCliente);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Ocurrió este error: {ex.Message}");
            }
        }

        [HttpPost]
        public ActionResult<VentaDto> Post(int Id_Clientes, VentaDto ventaDto)
        {
            try
            {

                if (Id_Clientes != ventaDto.Id_Clientes) return BadRequest("El cliente no existe");

                var VentaParaInsertar = mapper.Map<Venta>(ventaDto);

                var ClienteBuscado = clienteRepository.Obtener(Id_Clientes);
                if (ClienteBuscado == null) return BadRequest("El cliente no existe");

                //if (ventaDto.Vendedor == null) return BadRequest("El vendedor es obligatorio");
                //var VendedorBuscado = vendedorRepository.Obtener(ventaDto.Id_Vendedor);
                //var VendedorBuscado = vendedorRepository.Obtener(ventaDto.Vendedor.Id_Vendedor);
                //if (VendedorBuscado == null) return BadRequest("El vendedor no existe");


                VentaParaInsertar.Cliente = ClienteBuscado;
                VentaParaInsertar.EsNuevo = true;
                VentaParaInsertar.Modificado = true;
                //VentaParaInsertar.Vendedor = VendedorBuscado;

                if (ventaRepository.Grabar(ref VentaParaInsertar))
                {
                    var DireccionVentaNueva = linkGenerator.GetPathByAction("Obtener",
                       "Ventas",
                       new { Id_Clientes, VentaParaInsertar.Id_Ventas });

                    return Created(DireccionVentaNueva,
                                   mapper.Map<VentaDto>(VentaParaInsertar));
                }
                else
                {
                    return BadRequest("Ocurrió un erro al insertar la venta");
                }




            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Ocurrió este error: {ex.Message}");
            }

        }
    }
}
