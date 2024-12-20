using System;
using System.Collections.Generic;
using WebApi.Entity;

namespace WebApi.Data
{
    public class MarcaData : IListRepository<Marca>
    {
        private readonly IRepository<Marca> _context;

        public MarcaData(IRepository<Marca> context)
        {
            _context = context;
        }

        public string EntityName
        {
            get { return _context.EntityName; }
        }

        public List<Marca> List()
        {
            return _context.List();
        }

    }
}
