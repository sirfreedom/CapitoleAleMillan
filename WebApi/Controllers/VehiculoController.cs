using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net;
using System;
using WebApi.Biz;
using WebApi.Entity;
using System.Collections.Generic;
using WebApi.Model;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class VehiculoController : Controller
    {
        private readonly ILogger<ValuesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly string _ConectionString;

        public VehiculoController(ILogger<ValuesController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _ConectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        /// <summary>
        /// Lista todos los vehiculos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public ActionResult List()
        {
            List<Vehiculo> lVehiculo = new List<Vehiculo>();
            VehiculoService Serv = new VehiculoService(_ConectionString);
            try
            {
                lVehiculo = Serv.List();
            }
            catch (WebException ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            catch (Exception ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            return Ok(new { vehiculo = lVehiculo }); //OK 200
        }


        /// <summary>
        /// Inserta un nuevo vehiculo
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <returns>
        /// devuelve un 201 si esta la insercion correcta
        /// </returns>
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Insert(VehiculoDto vehiculo)
        {
            VehiculoService Serv = new VehiculoService(_ConectionString);
            Vehiculo oVehiculo = new Vehiculo();
            try
            {
                oVehiculo = Vehiculo.Merge<VehiculoDto, Vehiculo>(vehiculo);
                Serv.Insert(oVehiculo);
            }
            catch (WebException ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            catch (Exception ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            return Created(); //201
        }


    }
}
