using Microsoft.AspNetCore.Mvc;
using RepositoryGeneric.Infrastructure.Interfaz;
using RepositoryGeneric.Models;

namespace RepositoryGeneric.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryUser repo;
        public UserController(IRepositoryUser repo)
        {
            this.repo = repo;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User?>> Get(int id)
        {
            if (id == 0) return BadRequest();
            var user = await repo.FindByIdAsync(id);
            if (user == null) return NotFound();
            return user;
        }
        [HttpGet("admins")]
        public async Task<IEnumerable<User?>> GetAdmins()
        {
            return await repo.GetAdminsAsync();
        }
        //como usar el RepositoryUserAdmin
        [HttpGet("useradmins")]
        public async Task<IEnumerable<User?>> GetUserAdmins()
        {
            return await repo.GetAdminsAsync();
        }
    }
}
