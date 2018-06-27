using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace BackEnd
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DataBaseAccess data = new DataBaseAccess();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
