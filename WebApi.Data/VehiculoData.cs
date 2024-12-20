using System.Collections.Generic;
using WebApi.Entity;

namespace WebApi.Data
{
    public class VehiculoData : IListRepository<Vehiculo>, ICreateRepository<Vehiculo>
    {
        private readonly IRepository<Vehiculo> _context;

        public VehiculoData(IRepository<Vehiculo> context)
        {
            _context = context;
        }

        public string EntityName
        {
            get { return _context.EntityName; }
        }

        public void Insert(Dictionary<string, string> lParam)
        {
            _context.Insert(lParam);
        }

        public List<Vehiculo> List()
        {
            return _context.List();
        }
    }
}
