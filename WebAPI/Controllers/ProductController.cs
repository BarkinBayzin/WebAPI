using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        //actionResult => kendi nesnemiz custom model
        //Get ile başlayan methodlar, HttpGet isteği oluşturur,
        //Post ils başlayanlar HttpPost
        private List<ProductModel> _model;
        public ProductController()
        {
            _model = new List<ProductModel>
            {
                new ProductModel { Name = "Ayakkabı", Price = 100, Stock = 10 },
                new ProductModel { Name = "Kazak", Price = 45, Stock = 100 }
            };
        }
        [Route("GetProductByID/{id}")]
        [EnableCors(origins:"*",headers:"*",methods:"*")]
        public ProductModel GetProductByID(int id)
        {
            return new ProductModel { Name = "Test", Stock = 10, Price = 155 };
        }

        [EnableCors(origins:"*",headers:"*",methods:"*")]
        public List<ProductModel> GetProducts()
        {
            //List<ProductModel> _model = new List<ProductModel>
            //{
            //    new ProductModel { Name = "Ayakkabı", Price = 100, Stock = 10 },
            //    new ProductModel { Name = "Kazak", Price = 45, Stock = 100 }
            //};
            return _model;
        }

         //[EnableCors(origins:"*",headers:"*",methods:"*")]
        public string PostProduct(ProductModel model)
        {
            _model.Add(new ProductModel { Name ="Telefon",Price=5000,Stock = 20});
            return "Kayıt Başarılı";
        }
    }
}
