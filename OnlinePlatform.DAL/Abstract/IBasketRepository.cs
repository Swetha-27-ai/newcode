using OnlinePlatform.ENTITIES.Concrete;
using OnlinePlatform.ENTITIES.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OnlinePlatform.DAL.Abstract
{
    public interface IBasketRepository : IRepository<Basket>
    {
        List<BasketViewModel> GetBasketListByUserID(Expression<Func<BasketViewModel,bool>> filter );
    }
}
