using RepositoryGeneric.Infrastructure.Interfaz;
using RepositoryGeneric.Models;

namespace RepositoryGeneric.Infrastructure.Repository
{
    public class RepositoryUser : IRepositoryUser
    {
        // Lista de usuarios en memoria (en la practica lo obtendrias desde la bd)
        private readonly List<User> users = new()
        {
            new User { Id = 1, Name = "Viktor", Email = "viktor@gmail.com", UserType = UserType.Admin },
            new User { Id = 2, Name = "Jhon Doe", Email = "johnDoe@yahoo.com" },
            new User { Id = 3, Name = "Carla Peterson", Email = "carlapeterson@hotmail.com", UserType = UserType.Admin }
        };
        public async Task<User?> FindByIdAsync(int id)
        {
            //Simulo una pequeña demora para el metodo asincronico
            //Aqui realmente llamarias al servicio
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            return users.FirstOrDefault(x => x.Id == id);
        }
        public async Task<IEnumerable<User?>> GetAdminsAsync()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));
            return users.Where(x => x.UserType == UserType.Admin);
        }
    }
}
