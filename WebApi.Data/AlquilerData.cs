using System;
using System.Collections.Generic;
using WebApi.Entity;

namespace WebApi.Data
{
    public class AlquilerData : ICreateRepository<Alquiler>,IListRepository<Alquiler>
    {
        private readonly IRepository<Alquiler> _context;

        public AlquilerData(IRepository<Alquiler> context)
        {
            _context = context;
        }

        public string EntityName
        {
            get { return _context.EntityName; }
        }

        public void Insert(Dictionary<string, string> lParam)
        {
            try
            {
                _context.Insert(lParam);
            }
            catch (Exception ex) 
            { 
                throw ex;
            }
        }

        public List<Alquiler> List()
        {
            return _context.List();
        }

        public void Devolver(int IdVehiculo, string Observaciones) 
        {
            Dictionary<string,string> lParam = new Dictionary<string,string>();
            lParam.Add("IdVehiculo", IdVehiculo.ToString());
            lParam.Add("Observaciones", Observaciones);
            _context.ExecuteNonQuery("Devolver",lParam);
        }



    }
}
