
using Elementalist.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetUserOperationClaims(User user);
        void Add(User user);

        User GetByMail(string email);
    }
}
