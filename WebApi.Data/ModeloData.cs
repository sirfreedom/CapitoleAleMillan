using System.Collections.Generic;
using WebApi.Entity;

namespace WebApi.Data
{

    public class ModeloData : IListRepository<Modelo>
    {
        private readonly IRepository<Modelo> _context;

        public ModeloData(IRepository<Modelo> context)
        {
            _context = context;
        }

        public string EntityName
        {
            get { return _context.EntityName; }
        }

        public List<Modelo> List()
        {
            return _context.List();
        }

    }
}
