using System;

namespace WebApi.Model
{
    public class AlquilerDto
    {

        public int IdCliente { get; set; }

        public int IdVehiculo { get; set; }

        public DateOnly FechaInicio { get; set; }

        public DateOnly FechaFin { get; set; }

        public string Observaciones { get; set; }

    }
}
