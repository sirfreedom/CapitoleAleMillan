using System.Collections.Generic;
using WebApi.Data;
using WebApi.Entity;

namespace WebApi.Biz
{
    public class VehiculoService
    {

        private string _ConectionString = string.Empty;

        public VehiculoService(string ConecctionString) 
        { 
            _ConectionString = ConecctionString;
        }

        public void Insert(Vehiculo oVehiculo) 
        { 
            ICreateRepository<Vehiculo> Serv = new VehiculoData(new ContextSQL<Vehiculo>(_ConectionString));
            Serv.Insert(oVehiculo.PropertiesToDictionary());
        }

        public List<Vehiculo> List()
        {
            IListRepository<Vehiculo> Serv = new VehiculoData(new ContextSQL<Vehiculo>(_ConectionString));
            return Serv.List();
        }


    }
}
