using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System;
using WebApi.Biz;
using WebApi.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebApi.Model;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AlquilerController : Controller
    {
        private readonly ILogger<ValuesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly string _ConectionString;

        public AlquilerController(ILogger<ValuesController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _ConectionString = _configuration.GetConnectionString("DefaultConnection");
        }


        /// <summary>
        /// Lista los Alquileres
        /// </summary>
        /// <returns>
        /// retorna 
        /// </returns>
        [HttpGet]
        [AllowAnonymous]
        public ActionResult List()
        {
            AlquilerService Serv = new AlquilerService(_ConectionString);
            List<Alquiler> lAlquiler = new List<Alquiler>();
            try
            {
                 lAlquiler = Serv.List();
            }
            catch (WebException ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            catch (Exception ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            return Ok(new { alquileres = lAlquiler }); //OK 200
        }


        /// <summary>
        /// Alquila un vehiculo teniendo un cliente ya creado anteriormente, ver lista de clientes
        /// </summary>
        /// <param name="alquiler"></param>
        /// <returns>
        /// devuelve un codigo 201 o 204 de creacion
        /// </returns>
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Alquilar(AlquilerDto alquiler)
        {
            AlquilerService Serv = new AlquilerService(_ConectionString);
            Alquiler oAlquiler = new Alquiler();
            try
            {
                oAlquiler = Alquiler.Merge<AlquilerDto, Alquiler>(alquiler);
                Serv.Insert(oAlquiler);
            }
            catch (WebException ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            catch (Exception ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            return Created(); //201 204
        }


        /// <summary>
        /// Devuelve un vehiculo no importa si la fecha de fin es mas grande, no se hicieron demasiadas validaciones al respecto.
        /// </summary>
        /// <param name="IdVehiculo"></param>
        /// <param name="Observaciones"></param>
        /// <returns></returns>
        [HttpPut]
        [AllowAnonymous]
        public ActionResult Devolver(int IdVehiculo, string Observaciones)
        {
            AlquilerService Serv = new AlquilerService(_ConectionString);
            try
            {
                 Serv.Devolver(IdVehiculo, Observaciones);
            }
            catch (WebException ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            catch (Exception ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            return Ok();
        }





    }
}
