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
    public class MarcaController : Controller
    {

        private readonly ILogger<ValuesController> _logger;
        private readonly IConfiguration _configuration;
        private readonly string _ConectionString;

        public MarcaController(ILogger<ValuesController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _ConectionString = _configuration.GetConnectionString("DefaultConnection");
        }


        /// <summary>
        /// Lista las Marcas
        /// </summary>
        /// <returns>
        /// retorna lista de marcas
        /// </returns>
        [HttpGet]
        [AllowAnonymous]
        public ActionResult List()
        {
            MarcaService Serv = new MarcaService(_ConectionString);
            List<Marca> lMarca = new List<Marca>();
            try
            {
                lMarca = Serv.List();
            }
            catch (WebException ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            catch (Exception ex)
            {
                return ValidationProblem("Error", "Get", 500, ex.Message);
            }
            return Ok(new { Marcas = lMarca }); //OK 200
        }



    }
}
