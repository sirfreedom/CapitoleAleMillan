
namespace WebApi.Entity
{
	public class Vehiculo : EntityBase
	{
		public int IdMarca { get; set; }

		public int IdModelo { get; set; }

		public int IdEstado { get; set; }

		public string FechaModelo { get; set; }

		public string Marca { get; set; }

		public string Modelo { get; set; }	

		public string EstadoVehiculo { get; set; }

		public string Observaciones { get; set; }
	}

}