using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.UserCrudOp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUserCrud userCrud;
        public UserController(IUserCrud userCrud)
        {
            this.userCrud = userCrud;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            var data = userCrud.GetAllUsers();
            return Ok(data);
        }

        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(Users users)
        {
            userCrud.AddUser(users);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteUser")]
        public IActionResult DeleteUser(int id)
        {
            userCrud.DeleteUser(id);
            return Ok();
        }
    }
}
