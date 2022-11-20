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
            //Api istekleri json ve xml format�nda d��ar� a�ar e�er istersek bunlar� sadece json yada sadece xml format�nda apiden d�nd�rebilir.

            //iki farkl� formatter se�ene�imiz var, json ve xml

            //sadece xml d�nd�rmek i�in yapt���m�z ayar
            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedMediaTypes.Clear();

            //sadece json format�nda d�n��
            //GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            //Odatay� sisteme tan�tmak i�in a�a��daki kodu global asax'a tan�mlad�k.
            //art�k bu projede o data kullanaca��m� s�yl�yorum.
            GlobalConfiguration.Configuration.EnableQuerySupport();
        }
    }
}
