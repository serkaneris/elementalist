using Elementalist.Core.DataAccess;
using Elementalist.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetUserClaims(User user);
    }
}
