using System;

namespace WebApi.Entity
{
	public class Alquiler : EntityBase
	{

		public int IdCliente { get; set; }

		public int IdVehiculo { get; set; }

		public string Cliente { get; set; } 

		public string Marca { get; set; }
        
		public string Modelo { get; set; }

		public string EstadoVehiculo { get; set; }

        public string FechaInicio { get; set; }
			
		public string FechaFin {  get; set; }

		public string Observaciones { get; set; }
	}

}