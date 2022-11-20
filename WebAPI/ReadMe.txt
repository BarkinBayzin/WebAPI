
Global Asax da yapılanlar 

//sadece xml döndürmek için yaptığımız ayar
            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedMediaTypes.Clear();

            //sadece json formatında dönüş
            //GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            //Odatayı sisteme tanıtmak için aşağıdaki kodu global asax'a tanımladık.
            //artık bu projede o data kullanacağımı söylüyorum.
            GlobalConfiguration.Configuration.EnableQuerySupport();

Web Api Projemizde Odata kullanmak için nuget package managerdan asp.net webapi odata yı indirdik.
Odata açılımı opendata, verilerimizi urlden sorgulamak, filtrelemek, sıralamak gibi işlemleri hızlı bir şekilde client side bazlı yapmamızı sağlayan bir teknoloji.

Odatayı kullanmak için global asax'a. 
 GlobalConfiguration.Configuration.EnableQuerySupport(); kodu yapıştırdık

 Aynı zamanda filitreleme için TestController içerisine fake data attık

 TestController içerisindeki kodlar 
 
 [Queryable] attribute ile verilerimizi sorgulanabilir bir hale getiriyoruz. 
 Verilerimizin dönüş tipi sadece IQueryable<T> tipinde olabilir.
 Veritabanından çektiğimiz verileri .AsQueryable() methodu ile sorgulabilir bir şekilde döndürüyoruz.
 Bunun için client tarafındaki url ise search.html sayfasında mevcut

 https://localhost:44313/api/Test/GetTest?$filter=Name" + " eq %27" + inputValue + "%27, urisine istek yaparak veriyi filitreledik.

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