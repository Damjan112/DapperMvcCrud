using DapperMvcCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;

namespace DapperMvcCrud.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<ProductModel>("getAllProducts"));
        }
        //../Product/AddProduct
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(ProductModel productModel)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@p_productName", productModel.ProductName);
            param.Add("@p_supplierId", productModel.SupplierId);
            param.Add("@p_categoryId", productModel.CategoryId);
            param.Add("@p_quantityPerUnit", productModel.QuantityPerUnit);
            param.Add("@p_unitPrice", productModel.UnitPrice);
            param.Add("@p_unitsInStock", productModel.UnitsInStock);
            param.Add("@p_unitsOnOrder", productModel.UnitsOnOrder);
            param.Add("@p_reorderLevel", productModel.ReorderLevel);
            param.Add("@p_discontinued", productModel.Discontinued);
            param.Add("@p_lastUserId", productModel.LastUserId);
            DapperORM.ExecuteWithoutReturn("insertProduct", param);

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@p_productId", id);
            DapperORM.ExecuteWithoutReturn("deleteProductById", param);
            return RedirectToAction("Index");
        }
    }
}