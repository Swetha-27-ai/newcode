using OnlinePlatform.ENTITIES.Concrete;
using OnlinePlatform.ENTITIES.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OnlinePlatform.DAL.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<ProductBasketViewModel> GetListProductViewModel(Expression<Func<ProductBasketViewModel, bool>> filter);
        ProductBasketViewModel GetProductViewModel(Expression<Func<ProductBasketViewModel, bool>> filter);
    }
}
