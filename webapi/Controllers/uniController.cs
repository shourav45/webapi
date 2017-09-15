using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace webapi.Controllers
{
    public class uniController : Controller
    {
        public class RestaurantApiController : ApiController
        {
            [System.Web.Http.HttpGet]
            public HttpResponseMessage GetRestaurantInfo()
            {

                var result = new List<uniinfo>();
                try
                {
                    RestaurantInformationHandler std = new RestaurantInformationHandler();
                    List<RestaurantInformation> s = std.GetAll();
                    if (s.Count > 0)
                    {
                        result = s;
                        return Request.CreateResponse(HttpStatusCode.OK, result, "application/json");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, result, "application/json");
                    }
                }
                catch (Exception)
                {

                    return Request.CreateResponse(HttpStatusCode.OK, result, "application/json");
                }
            }

        }
    }
}
