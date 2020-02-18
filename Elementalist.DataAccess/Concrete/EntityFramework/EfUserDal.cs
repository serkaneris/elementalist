using Elementalist.Core.DataAccess.EntityFramework;
using Elementalist.DataAccess.Abstract;
using Elementalist.DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Elementalist.Core.Entities.Concrete;

namespace Elementalist.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepository<User, ElementalistDbContext>, IUserDal
    {
        public List<OperationClaim> GetUserClaims(User user)
        {
            using (var context = new ElementalistDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where
                             userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return  result.ToList();
            }
        }
    }
}
