using System.Collections.Generic;

namespace WebApi.Data.Interfaces
{
    public interface IUpdateRepository
    {
        string EntityName { get; }

        void Update(Dictionary<string, string> lParam);

    }
}
