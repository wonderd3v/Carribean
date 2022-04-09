using Carribean.API.Models.Entities;
using Carribean.API.Models.HttpModels;
using Carribean.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carribean.API.Controllers
{
    public class UserController : BaseController<User>
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) : base(userService)
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginModel userInformation)
        {
            var findedUser = _userService.FindUser(userInformation.UserName);

            if (findedUser == null)
                return BadRequest("You didn't pass me an user or a valid user");

            if(findedUser.Password != userInformation.Password)
                 return BadRequest("Password is incorrect");
            
       
            return Accepted(findedUser);
        }
    }
}
