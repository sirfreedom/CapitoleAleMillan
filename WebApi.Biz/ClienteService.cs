using System.Collections.Generic;
using WebApi.Data;
using WebApi.Entity;

namespace WebApi.Biz
{
    public class ClienteService
    {

        private string _ConectionString = string.Empty;

        public ClienteService(string ConecctionString)
        {
            _ConectionString = ConecctionString;
        }

        public List<Cliente> List()
        {
            IListRepository<Cliente> Serv = new ClienteData(new ContextSQL<Cliente>(_ConectionString));
            return Serv.List();
        }


    }
}
