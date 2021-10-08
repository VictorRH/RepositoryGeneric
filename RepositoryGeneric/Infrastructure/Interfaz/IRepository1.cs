using System.Threading.Tasks;
using static RepositoryGeneric.Core.ResponseUser;

namespace RepositoryGeneric.Infrastructure.Interfaz
{
    public interface IRepository1
    {
        Task<(bool result, ResponseUserRoot model, string ErrorMessage)> ResponseUserAdmin(string list);
    }
}
