using System.Collections.Generic;

namespace WebApi.Data
{
    public interface ICreateRepository<TEntity>
    {
        string EntityName { get; }

        void Insert(Dictionary<string, string> lParam);

    }
}
