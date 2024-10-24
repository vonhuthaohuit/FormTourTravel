using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult index()
        {
            string name = "Võ Nhựt Hào";
            int tuoi = 18;
            var result = new { name, tuoi };

            return Ok(result);
        }
    }
}
