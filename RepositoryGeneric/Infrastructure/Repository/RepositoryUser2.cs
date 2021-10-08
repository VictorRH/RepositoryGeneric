using RepositoryGeneric.Core;
using RepositoryGeneric.Infrastructure.Interfaz;
using System;
using System.Threading.Tasks;
using static RepositoryGeneric.Core.ResponseUser;

namespace RepositoryGeneric.Infrastructure.Repository
{
    public class RepositoryUser2 : IRepository2
    {
        public async Task<(bool result, ResponseUserRoot model, string ErrorMessage)> ResponseUserAdmin2(string list)
        {
            var private1 = await ResponseGateUserAdminPrivate2(list);

            return (true, private1.model, null);
           // throw new NotImplementedException();
        }


        private async Task<(bool result, ResponseUserRoot model, string ErrorMessage)> ResponseGateUserAdminPrivate2(string list)
        {
            var response2 = new ResponseUserRoot
            {
                Message = "Repository 2"
            };

            return (true, response2, null);
        }

    }
}
