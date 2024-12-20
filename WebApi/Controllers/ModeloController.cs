using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net;
using System;
using WebApi.Biz;
using WebApi.Entity;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ModeloController : Controller
    {
        private readonly ILogger<ValuesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly string _ConectionString;

        public ModeloController(ILogger<ValuesController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _ConectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        /// <summary>
        /// Lista los modelos de los vehiculos
        /// </summary>
        /// <returns>
        /// retorna 
        /// </returns>
        [HttpGet]
        [AllowAnonymous]
        public ActionResult List()
        {
            ModeloService Serv = new ModeloService(_ConectionString);
            List<Modelo> lModelo = new List<Modelo>();
            try
            {
                lModelo = Serv.List();
            }
            catch (WebException ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            catch (Exception ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            return Ok(new { Modelos = lModelo }); //OK 200
        }





    }
}
