using System.Collections.Generic;
using WebApi.Data;
using WebApi.Entity;

namespace WebApi.Biz
{
    public class MarcaService
    {
        private string _ConectionString = string.Empty;

        public MarcaService(string ConecctionString)
        {
            _ConectionString = ConecctionString;
        }

        public List<Marca> List()
        {
            IListRepository<Marca> Serv = new MarcaData(new ContextSQL<Marca>(_ConectionString));
            return Serv.List();
        }


    }
}
