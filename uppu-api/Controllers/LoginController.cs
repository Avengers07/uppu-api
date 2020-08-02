using Microsoft.AspNetCore.Mvc;
using uppu_api.Common;
using uppu_api.Models.Users;
using uppu_api.Services;

namespace uppu_api.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Authenticate([FromBody] AuthenticateModel authenticate)
        {
            if (string.IsNullOrWhiteSpace(authenticate.UserName) || string.IsNullOrWhiteSpace(authenticate.Password))
                return BadRequest(ErrorMessageConstants.UserNameMsg);
            var user = _userService.Authenticate(authenticate.UserName, authenticate.Password);

            //Need to perform operation

            return Ok();
        }
    }
}
