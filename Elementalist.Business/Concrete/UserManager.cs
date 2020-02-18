using Elementalist.Business.Abstract;
using Elementalist.Core.Entities.Concrete;
using Elementalist.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetUserOperationClaims(User user)
        {
            return _userDal.GetUserClaims(user);

        }
    }
}
