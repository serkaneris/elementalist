using Elementalist.Core.DataAccess.EntityFramework;
using Elementalist.DataAccess.Abstract;
using Elementalist.DataAccess.Concrete.EntityFramework.Contexts;
using Elementalist.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepository<Product, ElementalistDbContext>, IProductDal
    {
    }
}
