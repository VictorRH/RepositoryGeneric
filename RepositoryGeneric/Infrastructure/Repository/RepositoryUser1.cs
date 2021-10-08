using RepositoryGeneric.Core;
using RepositoryGeneric.Infrastructure.Interfaz;
using System;
using System.Threading.Tasks;
using static RepositoryGeneric.Core.ResponseUser;

namespace RepositoryGeneric.Infrastructure.Repository
{
    public class RepositoryUser1 : IRepository1
    {
        public async Task<(bool result, ResponseUserRoot model, string ErrorMessage)> ResponseUserAdmin(string list)
        {
            var private1 = await ResponseGateUserAdminPrivate(list);

            return (true, private1.model, null);
           // throw new NotImplementedException();
        }


        private async Task<(bool result, ResponseUserRoot model, string ErrorMessage)> ResponseGateUserAdminPrivate(string list)
        {
            var response2 = new ResponseUserRoot
            {
                Message = "Repository 1"
            };

            return (true, response2, null);
        }

    }
}
