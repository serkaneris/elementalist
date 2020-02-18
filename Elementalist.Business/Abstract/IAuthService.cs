using Elementalist.Core.Entities.Concrete;
using Elementalist.Core.Utilities.Results;
using Elementalist.Core.Utilities.Security.Jwt;
using Elementalist.Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
