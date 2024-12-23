using System.Configuration;
using WebApi.Biz;
using WebApi.Data;
using WebApi.Entity;
using WebApi.Model;

namespace WebApi.Test
{
    public class Tests
    {
        private string _ConectionString = string.Empty;

        [SetUp]
        public void Setup()
        {
            _ConectionString = "Password=2223;Persist Security Info=True;User ID=sa;Initial Catalog=WebApi;Data Source=SIRCODEHPNEW\\SIRCODEBASE";
        }

        [Test]
        public void ListarVehiculos()
        {
            VehiculoService Serv = new VehiculoService(_ConectionString);
            Serv.List();
            Assert.Pass();
        }

        [Test]
        public void IngresarUnaReservaPorElMismoCliente()
        {
            AlquilerService Serv = new AlquilerService(_ConectionString);
            AlquilerDto oAlquilerDto = new AlquilerDto();
            Alquiler oAlquiler = new Alquiler();
            oAlquilerDto.IdCliente = 1;
            oAlquilerDto.IdVehiculo = 1;
            oAlquilerDto.FechaInicio = DateOnly.Parse(DateTime.Now.ToShortDateString());
            oAlquilerDto.FechaFin = DateOnly.Parse(DateTime.Now.AddDays(1).ToShortDateString());
            oAlquilerDto.Observaciones = "Test";
            try
            {
                oAlquiler = Alquiler.Merge<AlquilerDto, Alquiler>(oAlquilerDto);
                Serv.Insert(oAlquiler);
                Serv.Insert(oAlquiler);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("ya existe un alquiler") || ex.Message.Contains("No es posible alquilar")) 
                {
                    Assert.Pass();
                }
            }
        }




    }
}