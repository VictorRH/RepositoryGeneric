using RepositoryGeneric.Core;
using RepositoryGeneric.Infrastructure.Interfaz;
using RepositoryGeneric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryGeneric.Infrastructure.Repository
{
    public class RepositoryUser : IRepositoryUser
    {
        // Lista de usuarios en memoria (en la practica lo obtendrias desde la bd)
        private List<User> users = new List<User> {
            new User { Id = 1, Name = "Viktor", Email = "viktor@gmail.com", UserType = UserType.Admin },
            new User { Id = 2, Name = "Jhon Doe", Email = "johnDoe@yahoo.com" },
            new User { Id = 3, Name = "Carla Peterson", Email = "carlapeterson@hotmail.com", UserType = UserType.Admin }
        };
        
        public async Task<User> FindByIdAsync(int id)
        {
            //Simulo una pequeña demora para el metodo asincronico
            //Aqui realmente llamarias al servicio
            await Task.Delay(TimeSpan.FromMilliseconds(100));

            var user = users.FirstOrDefault(x => x.Id == id);

            return user;
        }

        public async Task<IEnumerable<User>> GetAdminsAsync()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(100));

            var admins = users.Where(x => x.UserType == UserType.Admin);

            return admins;
        }
    }
}
