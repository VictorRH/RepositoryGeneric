using Microsoft.AspNetCore.Mvc;
using RepositoryGeneric.Core;
using RepositoryGeneric.Infrastructure.Interfaz;
using System.Threading.Tasks;

namespace RepositoryGeneric.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class User1Controller : ControllerBase
    {
        private readonly IRepository1 repository1;
        private readonly IRepository2 repository2;

        public User1Controller(IRepository1 repository1, IRepository2 repository2)
        {
            this.repository1 = repository1;
            this.repository2 = repository2;
        }
        [HttpPost("user1")]
        public async Task<ActionResult<ResponseUserDto>> POst1(ResponseUserDto model)
        {
            var responseRepository1 = await repository1.ResponseUserAdmin(model.Messag2);

            return Ok(responseRepository1.model.Message);

        }
        [HttpPost("user2")]
        public async Task<ActionResult<ResponseUserDto>> POst2(ResponseUserDto model)
        {
            var responseRepository2 = await repository2.ResponseUserAdmin2(model.Messag2);

            return Ok(responseRepository2.model.Message);

        }
    }
}
