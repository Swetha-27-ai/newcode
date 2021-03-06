using OnlinePlatform.BLL.Concrete;
using OnlinePlatform.DAL.Concrete;
using OnlinePlatform.ENTITIES.Concrete.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlinePlatform.MVC.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new ProductRepository());
        #region     Product
        [HttpGet]
        [Route("Product/ProductList")]
        public ActionResult ProductList()
        {
            return View(productManager.GetAll(u => u.Id < 16));
        }

        [HttpGet]
        [Route("Product/ProductDetail/{id}")]
        public ActionResult ProductDetail(int id)
        {
            int urunID =(int)id;
            ProductBasketViewModel productViewModel = productManager.GetProductViewModel(u => u.ProductID == urunID);
            return View(productViewModel);
        }
        #endregion
    }
}