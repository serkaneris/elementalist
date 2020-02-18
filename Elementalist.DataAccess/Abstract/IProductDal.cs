using Elementalist.Core.DataAccess;
using Elementalist.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
