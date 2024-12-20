
namespace WebApi.Data
{
    public interface IDeleteRepository
    {

        string EntityName { get; }

        void Delete(int Id);

    }
}
