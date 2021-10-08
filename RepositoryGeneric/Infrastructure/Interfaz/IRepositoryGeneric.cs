using System.Threading.Tasks;

namespace RepositoryGeneric.Infrastructure.Interfaz
{
    public interface IRepository<T> where T : class
    {
        //metodo util para todos los repos
        Task<T> FindByIdAsync(int id);
    }
}
