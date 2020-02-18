using Elementalist.Business.Abstract;
using Elementalist.Business.Constants;
using Elementalist.Core.Entities.Concrete;
using Elementalist.Core.Utilities.Results;
using Elementalist.Core.Utilities.Security.Hashing;
using Elementalist.Core.Utilities.Security.Jwt;
using Elementalist.Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        public AuthManager(IUserService userService,ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetUserOperationClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken,Messages.AccessTokenCreated);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if(userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            //password tuzlama ve hashleme yapilacak.
            if(!HashingHelper.VerifyPasswordHash(userForLoginDto.Password,userToCheck.PasswordHash,userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }
            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            var user = new User { 
                Email=userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true

            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserAdded);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                //User mail ile eşleşen kayıt varsa error dönüyoruz.
                return new ErrorResult(Messages.UserAllreadyExists);
            }
            return new SuccessResult();
        }
    }
}
