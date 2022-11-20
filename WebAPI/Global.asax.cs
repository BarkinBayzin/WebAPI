using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //Api istekleri json ve xml formatýnda dýþarý açar eðer istersek bunlarý sadece json yada sadece xml formatýnda apiden döndürebilir.

            //iki farklý formatter seçeneðimiz var, json ve xml

            //sadece xml döndürmek için yaptýðýmýz ayar
            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedMediaTypes.Clear();

            //sadece json formatýnda dönüþ
            //GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            //Odatayý sisteme tanýtmak için aþaðýdaki kodu global asax'a tanýmladýk.
            //artýk bu projede o data kullanacaðýmý söylüyorum.
            GlobalConfiguration.Configuration.EnableQuerySupport();
        }
    }
}
