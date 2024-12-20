using System.Configuration;
using WebApi.Data;
using WebApi.Entity;

namespace WebApi.Test
{
    public class Tests
    {
        private string _ConectionString = string.Empty;

        [SetUp]
        public void Setup()
        {
            _ConectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        [Test]
        public void ListarVehiculos()
        {
            IListRepository<Vehiculo> Serv = new VehiculoData(new ContextSQL<Vehiculo>(_ConectionString));
            Serv.List();
            Assert.Pass();
        }





    }
}