using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_2._0_Sample.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        [Route("api/product/hello/")]
        public IHttpActionResult Hello()
        {
            return Ok();
        }
    }
}
