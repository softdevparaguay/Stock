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
        private readonly IMapper mapper;
        private readonly LinkGenerator linkGenerator;

        public VentasController(VentaRepository ventaRepository,
                                IMapper mapper,
                                LinkGenerator linkGenerator)
        {
            this.ventaRepository = ventaRepository;
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
        public ActionResult<VentaDto> Obtener(int Id_Clientes,int Id_Ventas)
        {
            try
            {
                var VentaDelCliente = ventaRepository.ObtenerPorId_Clientes(Id_Clientes,Id_Ventas);

                if (VentaDelCliente == null) return NotFound();

                return mapper.Map<VentaDto>(VentaDelCliente);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Ocurrió este error: {ex.Message}");
            }
        }
    }
}
