using System.Threading.Tasks;

namespace RepositoryGeneric.Infrastructure.Interfaz
{
    public interface IRepositoryGeneric<T> where T : class
    {
        Task<(bool result, T model, string ErrorMessage)> ResponseMessage(string list);

    }
}
