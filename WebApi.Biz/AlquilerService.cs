using System;
using System.Collections.Generic;
using WebApi.Data;
using WebApi.Entity;

namespace WebApi.Biz
{
    public class AlquilerService
    {

        private string _ConectionString = string.Empty;

        public AlquilerService(string ConectionString)
        {
            _ConectionString = ConectionString;
        }

        public void Insert(Alquiler alquiler)
        {
            try
            {
                ICreateRepository<Alquiler> Serv = new AlquilerData(new ContextSQL<Alquiler>(_ConectionString));
                Serv.Insert(alquiler.PropertiesToDictionary());
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Alquiler> List()
        {
            IListRepository<Alquiler> Serv = new AlquilerData(new ContextSQL<Alquiler>(_ConectionString));
            return Serv.List();
        }

        public void Devolver(int IdVehiculo, string Observaciones) 
        {
            AlquilerData Serv = new AlquilerData(new ContextSQL<Alquiler>(_ConectionString));
            Serv.Devolver(IdVehiculo, Observaciones);
        }


    }
}
