using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class TestController : ApiController
    {
        //Odata => Open Data'nın kısaltılmışı, database'deki verileri çekerken query sorgu olarak çağırır ve javascripte yazdığımız url'e göre ek method açmadan tek bir merkezi noktadan sorgulama, filtreleme, arama gibi işlemleri yapabiliriz.

        //Odata ile bunu sorgulanabilir bir method haline getirdik
        //IQueryable dönüş tipinde sorgu döndüren methodlar tanımlıyoruz
        [EnableCors(origins:"*",headers:"*",methods:"*")] //Cors ayarlarını unutmadan açtım
        [Queryable]
        public IQueryable<TestModel> GetTest()
        {
            //Bütün data çekilir;
            List<TestModel> model = new List<TestModel>
            {
                new TestModel
                {
                    Name="Test1",
                    Description ="TestDescription1",
                    IsActive = true,
                    MaxValue=100,
                    MinValue =10
                },
                  new TestModel
                {
                    Name="Test2",
                    Description ="TestDescription2",
                    IsActive = true,
                    MaxValue=200,
                    MinValue =20
                },
                    new TestModel
                {
                    Name="Test3",
                    Description ="TestDescription3",
                    IsActive = false,
                    MaxValue=50,
                    MinValue =25
                },
                      new TestModel
                {
                    Name="Test4",
                    Description ="TestDescription4",
                    IsActive = true,
                    MaxValue=100,
                    MinValue =30
                },
                        new TestModel
                {
                    Name="Test5",
                    Description ="TestDescription5",
                    IsActive = true,
                    MaxValue=120,
                    MinValue =80
                }
            };
            //methodumuzun dönüş tipi IQueryable olduğu için sorgu döndürmek için listeyi AsQueryable() ile queryable a döndürdük.
            return model.AsQueryable();
        }
    }
}
