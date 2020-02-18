using Elementalist.Business.Abstract;
using Elementalist.Entities.Concrete.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elementalist.WebAPI.Controllers
{
    [Route(template:"api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost(template:"login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var loginResult = _authService.Login(userForLoginDto);
            if(!loginResult.Success)
            {
                return BadRequest(loginResult.Message);
            }
            //Login dogruysa Token olustur
            var createTokenResult = _authService.CreateAccessToken(loginResult.Data);
            if (!createTokenResult.Success)
            {
                return BadRequest(createTokenResult.Message);
            }
            return Ok(createTokenResult.Data);//Token geri dondurulur.
        }

        [HttpPost(template: "register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists =_authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto);
            if (!registerResult.Success)
            {
                return BadRequest(registerResult.Message);
            }
            var createTokenResult = _authService.CreateAccessToken(registerResult.Data);
            if (!createTokenResult.Success)
            {
                return BadRequest(registerResult.Message);
            }

            return Ok(createTokenResult.Data);
           
        }
    }
}
