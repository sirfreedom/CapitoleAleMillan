using System.Collections.Generic;
using WebApi.Data;
using WebApi.Entity;

namespace WebApi.Biz
{
    public class ModeloService
    {

        private string _ConectionString = string.Empty;

        public ModeloService(string ConecctionString)
        {
            _ConectionString = ConecctionString;
        }

        public List<Modelo> List()
        {
            IListRepository<Modelo> Serv = new ModeloData(new ContextSQL<Modelo>(_ConectionString));
            return Serv.List();
        }

    }
}
