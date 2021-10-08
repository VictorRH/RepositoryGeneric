using System.Collections.Generic;
using System.Threading.Tasks;
using RepositoryGeneric.Core;
using RepositoryGeneric.Models;

namespace RepositoryGeneric.Infrastructure.Interfaz
{
    public interface IRepositoryUser : IRepository<User>
    {
        //Este metodo ya no es del repo generico sino especifico del repo de Users
        Task<IEnumerable<User>> GetAdminsAsync();
    }
}
