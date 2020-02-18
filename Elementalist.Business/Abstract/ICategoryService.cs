using Elementalist.Core.Utilities.Results;
using Elementalist.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int categoryId);
        IDataResult<List<Category>> GetList();
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}
