using OnlinePlatform.ENTITIES.Concrete;
using OnlinePlatform.ENTITIES.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OnlinePlatform.BLL.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(Expression<Func<Product, bool>> filter = null);
        Product GetById(int id);
        Product Add(Product product);
        Product Update(Product product);
        int Max(Expression<Func<Product, int>> filter);

        List<ProductBasketViewModel> GetListProductViewModel(Expression<Func<ProductBasketViewModel, bool>> filter);
        ProductBasketViewModel GetProductViewModel(Expression<Func<ProductBasketViewModel, bool>> filter);

    }
}
