using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleWebApi.Controllers
{
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return this.Ok("Hi, this is a simple Web API which is to be containerized...Happy Containerizing");
        }
    }
}
