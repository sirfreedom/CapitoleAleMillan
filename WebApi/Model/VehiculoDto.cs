using System;

namespace WebApi.Model
{
    public class VehiculoDto
    {

        public int IdMarca { get; set; }

        public int IdModelo { get; set; }

        public int IdEstado { get; set; }

        public DateOnly FechaModelo { get; set; }

        public string Observaciones { get; set; }

    }
}
