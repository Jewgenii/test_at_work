using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Webapi_net.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //public IEnumerable<string> Get(string[]values)
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        public string Get(string id)
        {
            Content<int>(statusCode: HttpStatusCode.OK,value:1, formatter: Configuration.Formatters.JsonFormatter);
            
            return id;
        }
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
