using Elementalist.Business.Abstract;
using Elementalist.Business.Constants;
using Elementalist.Business.ValidationRoles.FluentValidation;
using Elementalist.Core.CrossCuttingConserns.Validation;
using Elementalist.Core.Utilities.Results;
using Elementalist.DataAccess.Abstract;
using Elementalist.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elementalist.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product); //Aspect Oriented hale getirilecek

            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.Id == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == categoryId).ToList());
        }

       
    }
}
